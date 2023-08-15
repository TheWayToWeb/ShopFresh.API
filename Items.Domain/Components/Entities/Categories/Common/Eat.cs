using Items.Domain.Components.Entities;

namespace Items.Domain.Components.Entities.Categories.Common
{
    public abstract class Eat : Item
    {
        public float Weight { get; set; }
        public string? CoolingMode { get; set; }
        public bool IsFarmer { get; set; }
    }
}
