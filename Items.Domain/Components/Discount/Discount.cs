using Items.Domain.Components.Entities.Common;

namespace Items.Domain.Components.Discount
{
    public class Discount
    {
        public Guid Id { get; private set; }
        public float Percent { get; private set; }
        public DateTime StartDiscount { get; private set; }
        public DateTime FinishDiscount { get; private set; }
        public Guid ItemId { get; private set; }
        public Item? Item { get; private set; }
    }
}
