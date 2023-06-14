using Range = Items.Domain.Products.Templates.Range;

namespace Items.Domain.Products.FreshItem.FruitsVegetables.Vegetables
{
    public class Potato : Vegetable
    {
        public List<Range> SaleWeights { get; set; } = new();
        public bool IsWash { get; set; }

    }
}
