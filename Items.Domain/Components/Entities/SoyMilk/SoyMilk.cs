using Items.Domain.Components.Entities.Common;

namespace Items.Domain.Components.Entities.SoyMilk
{
    public class SoyMilk : ItemFood
    {
        public List<FlavorName> Tastes { get; private set; } = new();
        public float FatContent { get; private set; }
        public float Volume { get; set; }
        public string? SoyMilkKind { get; private set; }
    }
}
