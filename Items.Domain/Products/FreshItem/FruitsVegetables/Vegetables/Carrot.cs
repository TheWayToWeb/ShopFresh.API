using Items.Domain.Products.FreshItem.FruitsVegetables;

namespace Items.Domain.Products.FreshItem.FruitsVegetables.Vegetables
{
    public class Carrot : Vegetable
    {
        public string? Grade { get; set; }
        public List<Range> SaleWeights { get; set; } = new();
        public bool IsWash { get; set; }
    }
}
