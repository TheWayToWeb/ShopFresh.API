using Items.Domain.Models.Categories.Vegetables;
using Range = Items.Domain.Models.Categories.Common.Range;

namespace Items.Domain.Entities.Categories.Vegetables.ConcretePotato.Potato
{
    public class Potato : Vegetable
    {
        public List<Range>? SaleWeights { get; set; } = new();
        public bool IsWash { get; set; }

    }
}
