namespace Items.Domain.Products.Category.SubCategory.FreshGroup.FreshItem.MilkProducts
{
    public class Yogurt : MilkProduct
    {
        public string? Kind { get; set; }
        public string? Taste { get; set; }
        public int FatContent { get; set; }
        public int Weight { get; set; }
        public string? Addition { get; set; }
        public List<string> Tastes { get; set; } = new();
        public bool IsInterest { get; set; }
    }
}
