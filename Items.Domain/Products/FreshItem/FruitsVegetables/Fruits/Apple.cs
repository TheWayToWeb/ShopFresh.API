using Items.Domain.Products.FreshItem.FruitsVegetables;

namespace Items.Domain.Products.FreshItem.FruitsVegetables.Fruits
{
    public class Apple : Fruit
    {
        public string? Grade { get; set; }
        public List<Range> SaleWeights { get; set; } = new();
    }
}
