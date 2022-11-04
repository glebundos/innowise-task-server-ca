using innowise_task_server.API.Controllers.Base;
using innowise_task_server.Application.Commands.FridgeCommands;
using innowise_task_server.Application.Queries.FridgeModelQueries;
using innowise_task_server.Application.Queries.FridgeQueries;
using innowise_task_server.Core.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace innowise_task_server.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FridgeModelController : ApiControllerBase
    {
        public FridgeModelController(IMediator mediator) : base(mediator) { }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<List<FridgeModel>>> Get()
        {
            return Single(await QueryAsync(new GetAllFridgeModelQuery()));
        }
    }
}
