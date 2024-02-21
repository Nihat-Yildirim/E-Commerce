using IdentityService.Domain.DTOs.ClaimDTOs;
using MediatR;
using ServiceCorePackages.ServiceCore.Domain.Response;

namespace IdentityService.Application.CQRS.Queries.ClaimQueries.GetAllClaim
{
    public class GetAllClaimQueryRequest : IRequest<DataResponse<List<ClaimDto>>>
    {
    }
}