using Items.Domain.Products.FreshItem.MilkProducts.LacticEntity;

namespace Items.Domain.Products.FreshItem.MilkProducts
{
    public class DrinkMilk : LacticProduct
    {
        public string? Taste { get; set; }
        public List<MilkFat> FatContent { get; set; } = new();
    }
}
