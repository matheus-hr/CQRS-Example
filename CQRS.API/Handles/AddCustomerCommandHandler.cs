using CQRS.API.Commands;
using CQRS.API.Entities;
using CQRS.API.Repositories;
using MediatR;

namespace CQRS.API.Handles
{
    public class AddCustomerCommandHandler : IRequestHandler<AddCustomerCommand, Guid> //This handler recives a AddCustomerCommand and return a Guid
    {
        private readonly ICustomerRepository _repository;

        public AddCustomerCommandHandler(ICustomerRepository repository)
        {
            _repository = repository;
        }

        public async Task<Guid> Handle(AddCustomerCommand command, CancellationToken cancellationToken)
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
