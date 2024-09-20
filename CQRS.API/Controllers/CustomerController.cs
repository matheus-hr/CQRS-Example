using MediatR;
using Microsoft.AspNetCore.Mvc;
using CQRS.API.Commands;
using CQRS.API.Repositories;
using CQRS.API.Queries;

namespace CQRS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CustomerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] AddCustomerCommand command)
        {
            var request = await _mediator.Send(command);
            return Created("Get", request);
        }

        [HttpGet] // FromQuery means that information comes in the URL, just like {id}
        public async Task<IActionResult> GetById([FromQuery] GetCustomerByIdQuery query)
        {
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [Route("GetByNameAndEmail")]
        [HttpPost] // FromQuery means that information comes in the URL, just like {id}
        public async Task<IActionResult> GetByNameAndEmail([FromBody] GetCustomerByNameAndEmail query)
        {
            var result = await _mediator.Send(query);
            return Ok(result);
        }
    }
}
