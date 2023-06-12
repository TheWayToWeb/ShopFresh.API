namespace Items.Domain.Products.FreshItem.Bakery
{
    public abstract class Bakery: Eat
    {
        public string? ProductBakeryKind { get; set; }
        public string? Addition { get; set; }
    }
}
