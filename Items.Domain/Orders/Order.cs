using Items.Domain.Components.Entities;

namespace Items.Domain.Orders
{
    public class Order
    {
        public Guid OrderId { get; private set; }
        public Guid PersonId { get; private set; }
        public string? City { get; private set; }
        public string? Region { get; private set; }
        public string? Country { get; private set; }
        public string? PostCode { get; private set; }
        public List<Item> Items { get; private set; } = new();
    }
}
