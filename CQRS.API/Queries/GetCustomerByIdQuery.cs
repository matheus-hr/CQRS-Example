using CQRS.API.Entities;
using MediatR;

namespace CQRS.API.Queries
{
    public class GetCustomerByIdQuery : IRequest<Customer> //This query when process, return a Customer
    {
        public Guid Id { get; set; }
    }
}
