namespace Items.Domain.Products.Category.SubCategory.FreshGroup.FreshItem.MilkProducts
{
    public class CottageCheese : MilkProduct
    {
        public string? KindProduct { get; set; }
        public string? Taste { get; set; }
        public float FatContent { get; set; }
        public int Weight { get; set; }
        public List<string> Tastes { get; set; } = new();
        public List<float> FatContents { get; set; } = new();
    }
}
