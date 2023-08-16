using Items.Domain.Components.Entities.Categories.Common;

namespace Items.Domain.Components.Entities.Categories.SoyMilk
{
    public class SoyMilk : ItemFood
    {
        public List<ProductTaste> Taste { get; private set; } = new();
        public List<SoldCapacity> Volume { get; private set; } = new();
        public string? KindOfMilk { get; private set; }
        public bool IsCold { get; private set; }
    }
}
