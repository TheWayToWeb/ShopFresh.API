namespace Items.Domain.Products.Category.SubCategory.FreshGroup.FreshItem.MilkProducts
{
    public class DrinkMilk : Milk
    {
        public string? Taste { get; set; }
        public List<MilkFat> FatContent { get; set; } = new();
    }
}
