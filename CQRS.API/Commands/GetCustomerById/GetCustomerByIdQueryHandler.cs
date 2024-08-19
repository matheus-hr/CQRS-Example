using CQRS.API.Entities;
using CQRS.API.Repositories;

namespace CQRS.API.Commands.GetCustomerById
{
    public class GetCustomerByIdQueryHandler
    {
        private readonly ICustomerRepository _repository;

        public GetCustomerByIdQueryHandler(ICustomerRepository repository)
        {
            _repository = repository;
        }

        public async Task<Customer> Handle(GetCustomerByIdQuery query)
        {
            return await _repository.GetById(query.Id);
        }
    }
}
