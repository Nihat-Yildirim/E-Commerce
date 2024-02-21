using IdentityService.Application.Repositories.ClaimRepositories;
using IdentityService.Domain.DTOs.ClaimDTOs;
using IdentityService.Domain.Entities;
using MediatR;
using ServiceCorePackages.ServiceCore.Application.UnitOfWork;
using ServiceCorePackages.ServiceCore.Domain.Response;
using System.Net;

namespace IdentityService.Application.CQRS.Commands.ClaimCommands.AddClaim
{
    public class AddClaimCommandHandler : IRequestHandler<AddClaimCommandRequest, DataResponse<ClaimDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IClaimReadRepository _claimReadRepository;
        private readonly IClaimWriteRepository _claimWriteRepository;

        public AddClaimCommandHandler(IUnitOfWork unitOfWork, IClaimReadRepository claimReadRepository, IClaimWriteRepository claimWriteRepository)
        {
            _unitOfWork = unitOfWork;
            _claimReadRepository = claimReadRepository;
            _claimWriteRepository = claimWriteRepository;
        }

        public async Task<DataResponse<ClaimDto>> Handle(AddClaimCommandRequest request, CancellationToken cancellationToken)
        {
            bool isNameExists = await _claimReadRepository.AnyAsync(x => x.Name.ToLower() == request.Name!.ToLower() && x.DeletedDate == null);
            if (isNameExists)
                return ResponseFactory.Fail<ClaimDto>(HttpStatusCode.BadRequest);

            Claim claim = new() { Name = request.Name! };
            await _claimWriteRepository.AddAsync(claim);
            await _unitOfWork.SaveChangesAsync();

            return ResponseFactory.Success(HttpStatusCode.OK, new ClaimDto(claim.Id, claim.Name));
        }
    }
}