using IdentityService.Application.Repositories.ClaimRepositories;
using IdentityService.Domain.DTOs.ClaimDTOs;
using MediatR;
using ServiceCorePackages.ServiceCore.Application.UnitOfWork;
using ServiceCorePackages.ServiceCore.Domain.Response;
using System.Net;

namespace IdentityService.Application.CQRS.Commands.ClaimCommands.UpdateClaim
{
    public class UpdateClaimCommandHandler : IRequestHandler<UpdateClaimCommandRequest, DataResponse<ClaimDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IClaimReadRepository _claimReadRepository;

        public UpdateClaimCommandHandler(IUnitOfWork unitOfWork, IClaimReadRepository claimReadRepository)
        {
            _unitOfWork = unitOfWork;
            _claimReadRepository = claimReadRepository;
        }

        public async Task<DataResponse<ClaimDto>> Handle(UpdateClaimCommandRequest request, CancellationToken cancellationToken)
        {
            bool isClaimExists = await _claimReadRepository.AnyAsync(x => x.Id == request.Id && x.DeletedDate == null);
            if (!isClaimExists)
                return ResponseFactory.Fail<ClaimDto>(HttpStatusCode.BadRequest);

            bool claimNameAlreadyExists = await _claimReadRepository.AnyAsync(x => x.Id != request.Id && x.Name == request.Name && x.DeletedDate == null);
            if(claimNameAlreadyExists)
                return ResponseFactory.Fail<ClaimDto>(HttpStatusCode.BadRequest);

            var selectedClaim = await _claimReadRepository.GetByIdAsync(request.Id);
            selectedClaim.Name = request.Name!;

            await _unitOfWork.SaveChangesAsync();

            return ResponseFactory.Success(HttpStatusCode.OK, new ClaimDto(selectedClaim.Id, selectedClaim.Name));
        }
    }
}