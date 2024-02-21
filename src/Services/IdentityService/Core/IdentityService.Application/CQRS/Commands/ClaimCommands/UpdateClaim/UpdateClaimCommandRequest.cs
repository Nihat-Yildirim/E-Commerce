using IdentityService.Domain.DTOs.ClaimDTOs;
using MediatR;
using ServiceCorePackages.ServiceCore.Domain.Response;

namespace IdentityService.Application.CQRS.Commands.ClaimCommands.UpdateClaim
{
    public class UpdateClaimCommandRequest : IRequest<DataResponse<ClaimDto>>
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
    }
}