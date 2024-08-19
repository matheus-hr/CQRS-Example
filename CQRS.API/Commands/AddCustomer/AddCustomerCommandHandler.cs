using CQRS.API.Entities;
using CQRS.API.Repositories;

namespace CQRS.API.Commands.AddCustomer
{
    public class AddCustomerCommandHandler
    {

        private readonly ICustomerRepository _repository;

        public AddCustomerCommandHandler(ICustomerRepository repository)
        {
            _repository = repository;
        }

        public async Task<Guid> Handle(AddCustomerCommand command) 
        {
            var customer = new Customer(
                command.FullName,
                command.PhoneNumber,
                command.Email
            );

            await _repository.Add(customer);

            return customer.Id; 
        }
    }
}
