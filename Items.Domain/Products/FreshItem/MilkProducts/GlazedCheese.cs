namespace Items.Domain.Products.FreshItem.MilkProducts
{
    public class GlazedCheese : LacticProduct
    {
        public string? Taste { get; set; }
        public float FatContent { get; set; }
        public bool IsHalal { get; set; }
    }
}
