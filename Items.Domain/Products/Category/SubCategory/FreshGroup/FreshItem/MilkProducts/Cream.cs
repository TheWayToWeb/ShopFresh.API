namespace Items.Domain.Products.Category.SubCategory.FreshGroup.FreshItem.MilkProducts
{
    public class Cream : MilkProduct
    {
        public string? KindCream { get; set; }
        public string? Taste { get; set; }
        public int FatContent { get; set; }
        public int Capacity { get; set; }
        public List<int> FatContents { get; set; } = new();
        public List<int> Capacities { get; set; } = new();
        public bool IsInterest { get; set; }

    }
}
