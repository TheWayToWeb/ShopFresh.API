using Items.Domain.Components.Entities.Common;
using Items.Domain.Components.Orders.Common;
using Items.Domain.Components.Person;

namespace Items.Domain.Components.Orders
{
    public class Order
    {
        public Guid Id { get; private set; }
        public List<Item> Items { get; private set; } = new();
        public Guid AddressId { get; private set; }
        public Address? Address { get; set; }
        public Guid UserId { get; private set; }
        public User? User { get; set; }
    }
}
