using Items.Domain.Components.Entities.Common;

namespace Items.Domain.Components.Entities.Water
{
    public class Beverage : ItemFood
    {
        public List<ProductTaste> Tastes { get; private set; } = new();
        public List<SoldCapacity> Volume { get; private set; } = new();
        public string? KindRelease { get; private set; }
        public bool IsCold { get; private set; }
    }
}
