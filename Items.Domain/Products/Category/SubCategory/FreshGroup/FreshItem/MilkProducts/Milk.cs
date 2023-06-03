namespace Items.Domain.Products.Category.SubCategory.FreshGroup.FreshItem.MilkProducts
{
    public abstract class Milk : Eatable
    {
        public string? ProcessMilk { get; set; }
        public string? KindOfMilk { get; set; }
        public string? Raw { get; set; }
        public bool IsLactoseFree { get; set; }
        public bool IsFarmer { get; set; }
        public bool IsVegan { get; set; }
        public bool IsBestseller { get; set; }
    }
}
