using Items.Domain.Components.Entities.Categories.Common;

namespace Items.Domain.Components.Entities.Categories.Fruits.Fruit
{
    public abstract class Fruit : Eat
    {
        public string? Grade { get; set; }
        public bool IsSlicingShape { get; set; }
        public string? Description { get; set; }
    }
}
