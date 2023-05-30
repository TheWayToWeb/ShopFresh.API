namespace Items.Domain.Products.Category.SubCategory.FreshGroup.FreshItem.MilkProducts
{
    public class Curd : MilkProduct
    {
        public string? Kind { get; set; }
        public string? Taste { get; set; }
        public float FatContent { get; set; }
        public int Weight { get; set; }
        public string? Addition { get; set; }
        public List<float>? FatContents { get; set; } = new();
        public bool IsInterest { get; set; }

    }
}
