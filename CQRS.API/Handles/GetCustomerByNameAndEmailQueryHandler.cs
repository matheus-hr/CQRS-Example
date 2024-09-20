using CQRS.API.Entities;
using CQRS.API.Queries;
using CQRS.API.Repositories;
using MediatR;

namespace CQRS.API.Handles
{
    public class GetCustomerByNameAndEmailQueryHandler : IRequestHandler<GetCustomerByNameAndEmail, Customer>
    {
        public readonly ICustomerRepository _customerRepository;

        public GetCustomerByNameAndEmailQueryHandler(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public Task<Customer> Handle(GetCustomerByNameAndEmail query, CancellationToken cancellationToken)
        {
            var customer = _customerRepository.GetByNameAndEmail(query.FullName, query.Email);
            return customer;
        }
    }
}
