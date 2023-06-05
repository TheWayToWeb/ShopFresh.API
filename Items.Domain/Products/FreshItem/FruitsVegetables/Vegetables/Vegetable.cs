using Items.Domain.Products.FreshItem;

namespace Items.Domain.Products.FreshItem.FruitsVegetables.Vegetables
{
    public abstract class Vegetable : Eatable
    {
        public string? ShortName { get; set; }
        public string? Description { get; set; }
    }
}
