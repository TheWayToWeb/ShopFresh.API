using Items.Domain.Products.FreshItem.MilkProducts.LacticEntity;

namespace Items.Domain.Products.FreshItem.MilkProducts
{
    public class Yogurt : LacticProduct
    {
        public string? TypeConsist { get; set; }
        public List<Taste>? Tastes { get; set; } = new();
        public float FatContent { get; set; }
    }
}
