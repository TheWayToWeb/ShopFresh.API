namespace Items.Domain.Products.Category.SubCategory.FreshGroup.FreshItem.MilkProducts
{
    public class MilkProduct : Item
    {
        public string? Type { get; set; }
        public string? Raw { get; set; }
        public string? CoolingMode { get; set; }
        public string? Storage { get; set; }
        public int MinTemp { get; set; }
        public int MaxTemp { get; set; }
        public DateOnly BeforeDate { get; set; }
        public string? Process { get; set; }
        public int Protein { get; set; }
        public float Fat { get; set; }
        public float Sugar { get; set; }
        public int Energy { get; set; }
        public bool IsFarmer { get; set; }
        public string? Package { get; set; }
    }
}
