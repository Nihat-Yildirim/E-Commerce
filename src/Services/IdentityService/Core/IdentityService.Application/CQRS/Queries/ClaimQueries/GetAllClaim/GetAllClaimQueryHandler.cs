using IdentityService.Application.Repositories.ClaimRepositories;
using IdentityService.Domain.DTOs.ClaimDTOs;
using MediatR;
using Microsoft.EntityFrameworkCore;
using ServiceCorePackages.ServiceCore.Domain.Response;
using System.Net;

namespace IdentityService.Application.CQRS.Queries.ClaimQueries.GetAllClaim
{
    public class GetAllClaimQueryHandler : IRequestHandler<GetAllClaimQueryRequest, DataResponse<List<ClaimDto>>>
    {
        private readonly IClaimReadRepository _claimReadRepository;

        public GetAllClaimQueryHandler(IClaimReadRepository claimReadRepository)
        {
            _claimReadRepository = claimReadRepository;
        }

        public async Task<DataResponse<List<ClaimDto>>> Handle(GetAllClaimQueryRequest request, CancellationToken cancellationToken)
        {
            var response = await _claimReadRepository.GetWhere(x => x.DeletedDate == null, false)
                .Select(x => new ClaimDto(x.Id, x.Name)).ToListAsync();

            return ResponseFactory.Success(HttpStatusCode.OK, response);
        }
    }
}