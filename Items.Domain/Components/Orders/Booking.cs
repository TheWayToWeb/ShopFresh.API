using Items.Domain.Components.Items;
using Items.Domain.Components.Orders.Common;
using Items.Domain.Components.Person;

namespace Items.Domain.Components.Orders
{
    public class Booking
    {
        public Guid Id { get; set; }
        public IEnumerable<Item> Items { get; set; }
        public Guid AddressId { get; set; }
        public Address Address { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
