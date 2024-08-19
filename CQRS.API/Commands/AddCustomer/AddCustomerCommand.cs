namespace CQRS.API.Commands.AddCustomer
{
    public class AddCustomerCommand
    {
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
