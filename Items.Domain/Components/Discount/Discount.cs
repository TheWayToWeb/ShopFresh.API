namespace Items.Domain.Components.Discount
{
    public class Discount
    {
        public Guid Id { get; private set; }
        public Guid ProductId { get; private set; }
        public float Percent { get; private set; }
        public DateTime StartDiscount { get; private set; }
        public DateTime EndDiscount { get; private set; }
        // public Product Product { get; set; }
    }
}
