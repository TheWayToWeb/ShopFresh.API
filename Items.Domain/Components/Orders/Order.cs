using Items.Domain.Components.Entities.Categories.Common;
using Items.Domain.Components.Orders.Common;

namespace Items.Domain.Components.Orders
{
    public class Order
    {
        public Guid OrderId { get; private set; }
        public Guid PersonId { get; private set; }
        public Guid AddressId { get; private set; }
        public Address? Address { get; set; }

        //public Person Person { get; set; }
        public List<Item> Items { get; private set; } = new();
    }
}
