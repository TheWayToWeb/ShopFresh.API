using Items.Domain.Components.Entities.Common;

namespace Items.Domain.Components.Entities.Milk
{
    public class Milk : ItemFood
    {
        public List<FlavorName> Tastes { get; private set; } = new();
        public List<FatContentProduct> FatContents { get; private set; } = new();
        public float Volume { get; set; }
        public bool IsMilkSugarFree { get; private set; }
    }
}
