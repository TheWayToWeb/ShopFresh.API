using Items.Domain.Components.Entities.Categories.Common;

namespace Items.Domain.Components.Entities.Categories.Yogurt
{
    public class Yogurt : ItemFood
    {
        public List<ProductTaste> Tastes { get; private set; } = new();
        public string? ViscousRelease { get; private set; }
    }
}
