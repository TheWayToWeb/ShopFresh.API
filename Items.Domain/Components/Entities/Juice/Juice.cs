using Items.Domain.Components.Entities.Common;

namespace Items.Domain.Components.Entities.Juice
{
    public class Juice : ItemFood
    {
        public List<ProductTaste> Tastes { get; private set; } = new();
        public List<SoldCapacity> Volume { get; private set; } = new();
        public bool IsCold { get; private set; }
    }
}
