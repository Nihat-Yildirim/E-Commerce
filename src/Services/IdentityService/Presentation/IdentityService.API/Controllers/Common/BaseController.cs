using MediatR;
using Microsoft.AspNetCore.Mvc;
using ServiceCorePackages.ServiceCore.Domain.Response;

namespace IdentityService.API.Controllers.Common
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public abstract class BaseController : ControllerBase
    {
        public readonly IMediator _mediator;
        public BaseController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [NonAction]
        public async Task<IActionResult> Response<TResponseParameters>(IRequest<DataResponse<TResponseParameters>> request)
            where TResponseParameters : class, new()
        {
            var response = await _mediator.Send(request);
            return new ObjectResult(response);
        }

        [NonAction]
        public async Task<IActionResult> Response(IRequest<Response> request)
        {
            var response = await _mediator.Send(request);
            return new ObjectResult(response);
        }
    }
}