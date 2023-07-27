using Items.Domain.Models.Categories.Common;

namespace Items.Domain.Models.Categories.Vegetables
{
    public abstract class Vegetable : Eat
    {
        public string? Grade { get; set; }
        public bool IsSlicingShape { get; set; }
    }
}
