using CQRS.API.Entities;
using CQRS.API.Repositories;

namespace CQRS.API.Persistance.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly List<Customer> _customerList;

        public CustomerRepository()
        {
            _customerList = new List<Customer>();
        }

        public async Task Add(Customer customer)
        {
            _customerList.Add(customer);
        }

        public async Task<Customer> GetById(Guid id)
        {
            return _customerList.FirstOrDefault(x => x.Id == id);
        }

        public async Task<Customer> GetByNameAndEmail(string name, string email)
        {
            return _customerList.FirstOrDefault(x => x.FullName == name && x.Email == email);
        }
    }
}
