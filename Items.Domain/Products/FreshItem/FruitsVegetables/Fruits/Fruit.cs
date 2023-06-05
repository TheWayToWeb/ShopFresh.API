using Items.Domain.Products.FreshItem;

namespace Items.Domain.Products.FreshItem.FruitsVegetables.Fruits
{
    public abstract class Fruit : Eatable
    {
        public string? ShortName { get; set; }
        public string? Description { get; set; }
        public string? Composition { get; set; }
    }
}
