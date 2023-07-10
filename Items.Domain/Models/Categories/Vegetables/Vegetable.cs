using Items.Domain.Enums;
using Items.Domain.Models.Categories.Common;

namespace Items.Domain.Models.Categories.Vegetables
{
    public abstract class Vegetable : Eat
    {
        public string? Sort { get; set; }
        public bool IsSlicingShape { get; set; }
    }
}
