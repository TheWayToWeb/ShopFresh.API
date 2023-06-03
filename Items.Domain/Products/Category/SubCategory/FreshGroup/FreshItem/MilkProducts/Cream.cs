namespace Items.Domain.Products.Category.SubCategory.FreshGroup.FreshItem.MilkProducts
{
    public class Cream : Milk
    {
        public string? KindCream { get; set; }
        public List<MilkFat> Fats { get; set; } = new();

    }
}
