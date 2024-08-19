using CQRS.API.Commands.AddCustomer;
using CQRS.API.Commands.GetCustomerById;
using CQRS.API.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;

namespace CQRS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepository _repository;

        public CustomerController(ICustomerRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] AddCustomerCommand command)
        {
            var handler = new AddCustomerCommandHandler(_repository);

            var id = await handler.Handle(command);

            return Created("Get", id);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var query = new GetCustomerByIdQuery(id);

            var handler = new GetCustomerByIdQueryHandler(_repository);
            var customer = await handler.Handle(query);

            return Ok(customer);
        }

    }
}
