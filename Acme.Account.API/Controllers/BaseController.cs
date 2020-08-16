using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.Net;
using System.Threading.Tasks;

namespace Acme.Account.API.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public abstract class BaseController<T> : ControllerBase where T : class
    {
        private IMediator _mediator;
        private ILogger<T> _logger;

        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();

        protected ILogger<T> Logger => _logger ??= HttpContext.RequestServices.GetService<ILogger<T>>();

        protected virtual async Task<IActionResult> Request(object request)
        {
            try
            {
                var result = await Mediator.Send(request);

                return Ok(result);

            }
            catch (System.Exception ex)
            {
                Logger.LogError(ex.Message, ex);
                return StatusCode((int)HttpStatusCode.InternalServerError, ex);
            }
        }
    }
}
