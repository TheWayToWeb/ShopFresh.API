using Items.Domain.Components.Entities.Common;

namespace Items.Domain.Components.Entities.JuiceDessert
{
    public class MilkyDesert : ItemFood
    {
        public List<FlavorName> Tastes { get; private set; } = new();
        public float Volume { get; private set; }
        public string? FormRelease { get; private set; }
        public bool IsCold { get; private set; }
    }
}
