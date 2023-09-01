using Items.Domain.Components.Entities.Common;

namespace Items.Domain.Components.Entities.Fruits
{
    public class Fruit : ItemFood
    {
        public string? Grade { get; private set; }
        public string? FormRelease { get; private set; }
        public string? CoolingMode { get; private set; }
        public string? SkinColor { get; private set; }
        public bool ByWeight { get; set; }
        public List<SalesRange> SalesWeights { get; private set; } = new();
    }
}
