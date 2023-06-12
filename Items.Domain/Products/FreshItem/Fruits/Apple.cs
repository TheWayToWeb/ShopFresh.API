using Items.Domain.Products.Templates;

namespace Items.Domain.Products.FreshItem.Fruits
{
    public class Apple : Fruit
    {
        public string? Grade { get; set; }
        public List<Range> SaleWeights { get; set; } = new();
    }
}
