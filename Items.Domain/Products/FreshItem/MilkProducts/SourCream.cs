using Items.Domain.Products.FreshItem.MilkProducts.LacticEntity;

namespace Items.Domain.Products.FreshItem.MilkProducts
{
    public class SourCream : LacticProduct
    {
        public List<MilkFat> FatContent { get; set; } = new();
        public bool IsHalal { get; set; }
    }
}
