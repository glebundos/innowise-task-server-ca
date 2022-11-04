using innowise_task_server.API.Controllers.Base;
using innowise_task_server.Application.Commands.FridgeCommands;
using innowise_task_server.Application.Commands.FridgeProductCommands;
using innowise_task_server.Application.Queries;
using innowise_task_server.Application.Queries.FridgeProductQueries;
using innowise_task_server.Core.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace innowise_task_server.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FridgeProductController : ApiControllerBase
    {
        public FridgeProductController(IMediator mediator) : base(mediator) { }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<List<FridgeProduct>>> Get()
        {
            return Single(await QueryAsync(new GetAllFridgeProductQuery()));
        }

        [HttpGet("id")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<FridgeProduct>> Get(Guid id)
        {
            return Single(await QueryAsync(new GetFridgeProductQuery(id)));
        }

        [HttpGet("fridge/{fridgeId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<List<FridgeProduct>>> GetByFridgeId(Guid fridgeId)
        {
            return Single(await QueryAsync(new GetAllFridgeProductByFridgeIdQuery(fridgeId)));
        }

        [HttpGet("fill")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<List<FridgeProduct>>> Fill()
        {
            return Single(await QueryAsync(new FillFridgeProductWhereQuantity0Query()));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<ActionResult> Create([FromBody] CreateFridgeProductCommand command)
        {
            return CreatedAtAction(nameof(Create), await CommandAsync(command));
        }

        [HttpPost("many")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<ActionResult> CreateMany([FromBody] CreateManyFridgeProductCommand command)
        {
            return CreatedAtAction(nameof(Create), await CommandAsync(command));
        }

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult> Delete([FromBody] DeleteFridgeProductCommand command)
        {
            return Ok(await CommandAsync(command));
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult> Update([FromBody] UpdateFridgeProductCommand command)
        {
            return Ok(await CommandAsync(command));
        }

        [HttpPut("many")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult> UpdateMany([FromBody] UpdateManyFridgeProductCommand command)
        {
            return Ok(await CommandAsync(command));
        }
    }
}
