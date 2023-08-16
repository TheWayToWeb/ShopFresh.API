using Items.Domain.Components.Entities.Categories.Common;

namespace Items.Domain.Components.Entities.Categories.JuiceDessert
{
    public class JuiceDessert : ItemFood
    {
        public List<ProductTaste> Tastes { get; private set; } = new();
        public float Volume { get; private set; }
        public string? FormRelease { get; private set; }
        public bool IsCold { get; private set; }
    }
}
