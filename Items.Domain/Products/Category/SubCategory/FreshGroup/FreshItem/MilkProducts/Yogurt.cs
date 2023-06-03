namespace Items.Domain.Products.Category.SubCategory.FreshGroup.FreshItem.MilkProducts
{
    public class Yogurt : Milk
    {
        public string? TypeConsist { get; set; }
        public List<Taste>? Tastes { get; set; } = new();
        public float FatContent { get; set; }
    }
}
