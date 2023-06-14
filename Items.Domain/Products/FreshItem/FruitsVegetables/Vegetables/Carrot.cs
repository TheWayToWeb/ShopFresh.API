using Range = Items.Domain.Products.Templates.Range;

namespace Items.Domain.Products.FreshItem.FruitsVegetables.Vegetables
{
    public class Carrot : Vegetable
    {
        public List<Range>? SaleWeights { get; set; } = new();
        public bool IsWash { get; set; }
    }
}
