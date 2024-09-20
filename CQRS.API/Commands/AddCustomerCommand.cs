using MediatR;

namespace CQRS.API.Commands
{
    public class AddCustomerCommand : IRequest<Guid> //This command when process, return a Guid
    {
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
