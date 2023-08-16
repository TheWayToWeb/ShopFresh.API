using Items.Domain.Components.Entities.Categories.Common;

namespace Items.Domain.Components.Entities.Categories.Cheese
{
    public class Cheese : ItemFood
    {
        public List<ProductTaste> Taste { get; private set; } = new();
        public string? FormRelease { get; private set; }
        public string? PrimaryProduct { get; private set; }
    }
}
