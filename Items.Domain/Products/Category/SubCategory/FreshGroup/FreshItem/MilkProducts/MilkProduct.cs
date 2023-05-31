namespace Items.Domain.Products.Category.SubCategory.FreshGroup.FreshItem.MilkProducts
{
    public class MilkProduct : Eatable
    {
        public string? Type { get; set; }
        public string? Raw { get; set; }
        public string? Process { get; set; }
        public bool IsFarmer { get; set; }
        public string? Package { get; set; }
    }
}
