using Items.Domain.Components.Entities.Common;
using SalesRange = Items.Domain.Components.Entities.Common.SalesRange;

namespace Items.Domain.Components.Entities.Vegetables
{
    public class Vegetable : ItemFood
    {
        public string? Grade { get; private set; }
        public string? FormRelease { get; private set; }
        public string? CoolingMode { get; private set; }
        public string? SkinColor { get; private set; }
        public List<SalesRange> SalesWeights { get; private set; } = new();
    }
}
