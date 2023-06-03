using Items.Domain.Products.Category.SubCategory.FreshGroup.FreshItem.MilkProducts;

namespace Items.Domain.Products.Category.SubCategory.FreshGroup.FreshItem
{
    public abstract class Eatable : Item
    {
        public int MinTemp { get; set; }
        public int MaxTemp { get; set; }
        public string? CoolingMode { get; set; }
        public string? Shape { get; set; }
        public string? Contain { get; set; }
        public float? Weight { get; set; }
        public List<Capacity>? Capacities { get; set; } = new();
        public float Protein { get; set; }
        public float Fat { get; set; }
        public float Sugar { get; set; }
        public float Energy { get; set; }
        public int CountInPackage { get; set; }
        public DateOnly BeforeDate { get; set; }
        public string? Package { get; set; }
    }
}
