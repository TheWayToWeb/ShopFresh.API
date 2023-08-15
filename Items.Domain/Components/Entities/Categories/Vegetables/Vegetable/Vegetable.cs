using Items.Domain.Components.Entities.Categories.Common;

namespace Items.Domain.Components.Entities.Categories.Vegetables.Vegetable
{
    public abstract class Vegetable : Eat
    {
        public string? Grade { get; set; }
        public bool IsSlicingShape { get; set; }
    }
}
