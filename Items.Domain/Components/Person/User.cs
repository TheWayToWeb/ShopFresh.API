using Items.Domain.Components.Feedback;
using Items.Domain.Components.Orders.Common;
using Items.Domain.Components.Payment;

namespace Items.Domain.Components.Person
{
    public class User
    {
        public Guid Id { get; private set; }
        public string? FirstName { get; private set; }
        public string? LastName { get; private set; }
        public Guid AddressId { get; private set; }
        public Address? Address { get; set; }
        public List<Review> Reviews { get; private set; } = new();
        public Guid PaymentMethodId { get; private set; }
        public PaymentMethod? PaymentMethod { get; set; }

    }
}
