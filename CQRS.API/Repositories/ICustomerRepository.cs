using CQRS.API.Entities;

namespace CQRS.API.Repositories
{
    public interface ICustomerRepository
    {
        Task Add(Customer customer);

        Task<Customer> GetById(Guid id);
    }
}
