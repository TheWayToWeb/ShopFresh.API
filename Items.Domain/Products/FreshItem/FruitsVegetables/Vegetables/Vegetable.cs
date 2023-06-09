namespace Items.Domain.Products.FreshItem.FruitsVegetables.Vegetables
{
    public abstract class Vegetable : Eat
    {
        public string? ShortName { get; set; }
        public string? Description { get; set; }
    }
}
