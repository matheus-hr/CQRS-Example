namespace CQRS.API.Entities
{
    public class Customer
    {
        public Customer(string fullName, string phoneNumber, string email)
        {
            Id = Guid.NewGuid();
            FullName = fullName;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public Guid Id { get; private set; }
        public string FullName { get; private set; }
        public string PhoneNumber { get; private set; }
        public string Email { get; private set; }
    }
}
