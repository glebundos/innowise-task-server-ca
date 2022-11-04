using innowise_task_server.API.Controllers.Base;
using innowise_task_server.Application.Commands.FridgeCommands;
using innowise_task_server.Application.Queries.FridgeQueries;
using innowise_task_server.Core.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace innowise_task_server.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FridgeController : ApiControllerBase
    {
        public FridgeController(IMediator mediator) : base(mediator) { }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<List<Fridge>>> Get()
        {
            return Single(await QueryAsync(new GetAllFridgeQuery()));
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Fridge>> Get(Guid id)
        {
            return Single(await QueryAsync(new GetFridgeQuery(id)));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<ActionResult> Create([FromBody] CreateFridgeCommand command)
        {
            return CreatedAtAction(nameof(Create), await CommandAsync(command));
        }

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult> Delete([FromBody] DeleteFridgeCommand command)
        {
            return Ok(await CommandAsync(command));
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult> Update([FromBody] UpdateFridgeCommand command)
        {
            return Ok(await CommandAsync(command));
        }
    }
}
