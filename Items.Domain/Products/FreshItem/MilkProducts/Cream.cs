using Items.Domain.Products.FreshItem.MilkProducts.LacticEntity;

namespace Items.Domain.Products.FreshItem.MilkProducts
{
    public class Cream : LacticProduct
    {
        public string? KindCream { get; set; }
        public List<MilkFat> FatContent { get; set; } = new();

    }
}
