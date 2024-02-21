using IdentityService.Application.Repositories.ClaimRepositories;
using MediatR;
using ServiceCorePackages.ServiceCore.Application.UnitOfWork;
using ServiceCorePackages.ServiceCore.Domain.Response;
using System.Net;

namespace IdentityService.Application.CQRS.Commands.ClaimCommands.DeleteClaim
{
    public class DeleteClaimCommandHandler : IRequestHandler<DeleteClaimCommandRequest, Response>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IClaimReadRepository _claimReadRepository;
        private readonly IClaimWriteRepository _claimWriteRepository;

        public DeleteClaimCommandHandler(IUnitOfWork unitOfWork, IClaimReadRepository claimReadRepository, IClaimWriteRepository claimWriteRepository)
        {
            _unitOfWork = unitOfWork;
            _claimReadRepository = claimReadRepository;
            _claimWriteRepository = claimWriteRepository;
        }

        public async Task<Response> Handle(DeleteClaimCommandRequest request, CancellationToken cancellationToken)
        {
            var selectedClaim = await _claimReadRepository.GetSingleAsync(x => x.Id  == request.Id && x.DeletedDate == null);
            if (selectedClaim == null)
                return ResponseFactory.Fail(HttpStatusCode.BadRequest);

            selectedClaim.DeletedDate = DateTime.Now;
            await _unitOfWork.SaveChangesAsync();

            return ResponseFactory.Success(HttpStatusCode.NoContent);
        }
    }
}