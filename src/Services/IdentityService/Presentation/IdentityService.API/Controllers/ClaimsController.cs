using IdentityService.API.Controllers.Common;
using IdentityService.Application.CQRS.Commands.ClaimCommands.AddClaim;
using IdentityService.Application.CQRS.Commands.ClaimCommands.DeleteClaim;
using IdentityService.Application.CQRS.Commands.ClaimCommands.UpdateClaim;
using IdentityService.Application.CQRS.Queries.ClaimQueries.GetAllClaim;
using IdentityService.Application.CQRS.Queries.ClaimQueries.GetClaimById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace IdentityService.API.Controllers
{
    public class ClaimsController : BaseController
    {
        public ClaimsController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost]
        public async Task<IActionResult> AddClaim([FromBody] AddClaimCommandRequest request)
            => await Response(request);

        [HttpPut]
        public async Task<IActionResult> UpdateClaim([FromBody] UpdateClaimCommandRequest request)
            => await Response(request);

        [HttpDelete]
        public async Task<IActionResult> DeleteClaim([FromQuery] DeleteClaimCommandRequest request)
            => await Response(request);

        [HttpGet]
        public async Task<IActionResult> GetAllClaim([FromQuery] GetAllClaimQueryRequest request)
            => await Response(request);

        [HttpGet]
        public async Task<IActionResult> GetClaimById([FromQuery] GetClaimByIdQueryRequest request)
            => await Response(request);
    }
}