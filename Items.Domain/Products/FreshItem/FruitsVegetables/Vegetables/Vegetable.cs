using Items.Domain.Enums;

namespace Items.Domain.Products.FreshItem.FruitsVegetables.Vegetables
{
    public abstract class Vegetable : Eat
    {
        public string? Sort { get; set; }
        public bool IsSlicingShape { get; set; }
    }
}
