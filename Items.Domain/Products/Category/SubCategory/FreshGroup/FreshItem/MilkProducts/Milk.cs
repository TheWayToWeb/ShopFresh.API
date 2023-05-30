namespace Items.Domain.Products.Category.SubCategory.FreshGroup.FreshItem.MilkProducts
{
    public class Milk : MilkProduct
    {
        public string? MilkType { get; set; }
        public string? Taste { get; set; }
        public float FatContent { get; set; }
        public int Capacity { get; set; }
        public List<float> FatContents { get; set; } = new();
        public List<int> Capacities { get; set; } = new();
        public bool IsInterest { get; set; }

    }
}
