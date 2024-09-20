using CQRS.API.Entities;
using MediatR;

namespace CQRS.API.Queries
{
    public class GetCustomerByNameAndEmail : IRequest<Customer> //This query when process, return a Customer
    {
        public string FullName { get; set; }
        public string Email { get; set; }
    }
}
