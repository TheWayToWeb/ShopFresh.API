using Items.Domain.Components.Entities;

namespace Items.Domain.Orders
{
    public class OrderDetails
    {
        public Guid OrderId { get; private set; }
        public Guid PersonId { get; private set; }
        public List<Item> Items { get; private set; } = new();
        public float OrderPrice { get; private set; }
        public string Address { get; private set; } = string.Empty;
        public DateTime DispatchDate { get; private set; }
        public DateTime ReceiptDate { get; private set; }
    }
}
