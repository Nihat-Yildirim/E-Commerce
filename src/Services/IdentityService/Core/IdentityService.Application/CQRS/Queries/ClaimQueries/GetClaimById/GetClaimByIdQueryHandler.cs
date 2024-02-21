using IdentityService.Application.Repositories.ClaimRepositories;
using IdentityService.Domain.DTOs.ClaimDTOs;
using MediatR;
using ServiceCorePackages.ServiceCore.Domain.Response;
using System.Net;

namespace IdentityService.Application.CQRS.Queries.ClaimQueries.GetClaimById
{
    public class GetClaimByIdQueryHandler : IRequestHandler<GetClaimByIdQueryRequest, DataResponse<ClaimDto>>
    {
        private readonly IClaimReadRepository _claimReadRepository;

        public GetClaimByIdQueryHandler(IClaimReadRepository claimReadRepository)
        {
            _claimReadRepository = claimReadRepository;
        }

        public async Task<DataResponse<ClaimDto>> Handle(GetClaimByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var selectedClaim = await _claimReadRepository.GetByIdAsync(request.Id);
            if (selectedClaim == null)
                return ResponseFactory.Fail<ClaimDto>(HttpStatusCode.BadRequest);

            return ResponseFactory.Success(HttpStatusCode.OK, new ClaimDto { Id = selectedClaim.Id, Name = selectedClaim.Name });
        }
    }
}