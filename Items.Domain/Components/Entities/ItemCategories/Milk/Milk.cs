using Items.Domain.Components.Entities.Categories.Common;

namespace Items.Domain.Components.Entities.Categories.Milk
{
    public class Milk : ItemFood
    {
        public List<ProductTaste> Tastes { get; private set; } = new();
        public List<FatContentProduct> FatContents { get; private set; } = new();
        public List<SoldCapacity> Volume { get; private set; } = new();
        public bool IsMilkSugarFree { get; private set; }
    }
}
