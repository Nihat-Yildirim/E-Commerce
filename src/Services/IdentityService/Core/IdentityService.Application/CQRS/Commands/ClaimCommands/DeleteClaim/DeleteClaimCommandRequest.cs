using MediatR;
using ServiceCorePackages.ServiceCore.Domain.Response;

namespace IdentityService.Application.CQRS.Commands.ClaimCommands.DeleteClaim
{
    public class DeleteClaimCommandRequest : IRequest<Response>
    {
        public Guid Id { get; set; }
    }
}