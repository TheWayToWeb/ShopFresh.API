using Range = Items.Domain.Models.Categories.Common.Range;

namespace Items.Domain.Models.Categories.Vegetables
{
    public class Potato : Vegetable
    {
        public List<Range>? SaleWeights { get; set; } = new();
        public bool IsWash { get; set; }

    }
}
