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
            Console.WriteLine("Add Customer");
            _customerList.Add(customer);
        }

        public async Task<Customer> GetById(Guid id)
        {
            Console.WriteLine("Get Customer By Id");
            return _customerList.FirstOrDefault(x => x.Id == id);
        }
    }
}
