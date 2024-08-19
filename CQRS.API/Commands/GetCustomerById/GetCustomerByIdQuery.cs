namespace CQRS.API.Commands.GetCustomerById
{
    public class GetCustomerByIdQuery
    {
        public GetCustomerByIdQuery(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}
