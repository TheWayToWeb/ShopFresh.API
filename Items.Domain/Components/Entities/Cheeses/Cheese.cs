using Items.Domain.Components.Entities.Common;

namespace Items.Domain.Components.Entities.Cheeses
{
    public class Cheese : ItemFood
    {
        public List<ProductTaste> Tastes { get; private set; } = new();
        public string? FormRelease { get; private set; }
        public string? PrimaryProduct { get; private set; }
        public List<SalesRange> SalesWeights { get; private set; } = new();
        public bool InParts { get; private set; }
    }
}
