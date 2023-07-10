using Items.Domain.Models.Categories.Common;

namespace Items.Domain.Models.Categories.Fruits
{
    public class Apple : Fruit
    {
        public string? Grade { get; set; }
        public List<Range> SaleWeights { get; set; } = new();
    }
}
