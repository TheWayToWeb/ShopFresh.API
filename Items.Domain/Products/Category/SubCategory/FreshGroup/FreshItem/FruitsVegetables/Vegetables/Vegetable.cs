namespace Items.Domain.Products.Category.SubCategory.FreshGroup.FreshItem.FruitsVegetables.Vegetables
{
    public abstract class Vegetable : Item
    {
        public string? ShortName { get; set; }
        public string? Description { get; set; }
        public string? Package { get; set; }
    }
}
