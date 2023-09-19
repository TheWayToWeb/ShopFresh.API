using Items.Domain.Components.Entities.Common;

namespace Items.Domain.Components.Entities.Yogurt
{
    public class Yogurt : ItemFood
    {
        public List<FlavorName> Tastes { get; private set; } = new();
        public string? ViscousRelease { get; private set; }
    }
}
