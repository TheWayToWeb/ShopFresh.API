using Items.Domain.Components.Entities.Common;

namespace Items.Domain.Components.Entities.Juices
{
    public class Juice : ItemFood
    {
        public List<FlavorName> Tastes { get; private set; } = new();
        public List<SoldCapacity> Volume { get; private set; } = new();
        public int AgeLimit { get; set; }
        public bool IsCold { get; private set; }
    }
}
