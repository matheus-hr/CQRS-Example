using CQRS.API.Entities;
using CQRS.API.Queries;
using CQRS.API.Repositories;
using MediatR;

namespace CQRS.API.Handles
{
    public class GetCustomerByIdQueryHandler : IRequestHandler<GetCustomerByIdQuery, Customer> //This handler recevies a GetCustomerByIdQuery and return a Customer
    {
        private readonly ICustomerRepository _repository;

        public GetCustomerByIdQueryHandler(ICustomerRepository repository)
        {
            _repository = repository;
        }

        public Task<Customer> Handle(GetCustomerByIdQuery query, CancellationToken cancellationToken)
        {
            var customer = _repository.GetById(query.Id);
            return customer;
        }
    }
}
