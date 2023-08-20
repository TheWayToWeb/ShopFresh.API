using Items.Domain.Components.Entities.Common;

namespace Items.Domain.Components.Entities.Milk
{
    public class Milk : ItemFood
    {
        public List<ProductTaste> Tastes { get; private set; } = new();
        public List<FatContentProduct> FatContents { get; private set; } = new();
        public List<SoldCapacity> Volume { get; private set; } = new();
        public bool IsMilkSugarFree { get; private set; }
    }
}
