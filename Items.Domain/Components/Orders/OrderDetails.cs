using Items.Domain.Components.Entities.Common;
using Items.Domain.Components.Orders.Common;

namespace Items.Domain.Components.Orders
{
    public class OrderDetails
    {
        public Guid Id { get; private set; }
        public float OrderPrice { get; private set; }
        public DateTime DispatchDate { get; private set; }
        public DateTime ReceiptDate { get; private set; }
        public Guid AddressId { get; private set; }
        public Address? Address { get; set; }
        public Guid OrderId { get; private set; }
        public Order? Order { get; set; }
    }
}
