using Items.Domain.Components.Items;

namespace Items.Domain.Components.Discount
{
    public class Discount
    {
        public Guid Id { get; set; }
        public float Percent { get; set; }
        public DateTime StartDiscount { get; set; }
        public DateTime FinishDiscount { get; set; }
        public Guid ItemId { get; set; }
        public Item Item { get; set; }
    }
}
