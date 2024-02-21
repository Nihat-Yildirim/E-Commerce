using IdentityService.Domain.DTOs.ClaimDTOs;
using MediatR;
using ServiceCorePackages.ServiceCore.Domain.Response;

namespace IdentityService.Application.CQRS.Commands.ClaimCommands.AddClaim
{
    public class AddClaimCommandRequest : IRequest<DataResponse<ClaimDto>>
    {
        public string? Name { get; set; }
    }
}