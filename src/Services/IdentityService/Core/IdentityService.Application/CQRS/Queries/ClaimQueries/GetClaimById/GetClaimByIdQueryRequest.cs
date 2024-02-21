using IdentityService.Domain.DTOs.ClaimDTOs;
using MediatR;
using ServiceCorePackages.ServiceCore.Domain.Response;

namespace IdentityService.Application.CQRS.Queries.ClaimQueries.GetClaimById
{
    public class GetClaimByIdQueryRequest : IRequest<DataResponse<ClaimDto>>
    {
        public Guid Id { get; set; }
    }
}