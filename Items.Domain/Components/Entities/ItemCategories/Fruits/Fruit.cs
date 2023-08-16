using Items.Domain.Components.Entities.Categories.Common;
using Items.Domain.Components.Entities.Categories.Fruits.Common;
using SalesLine = Items.Domain.Components.Entities.Categories.Fruits.Common.SalesLine;

namespace Items.Domain.Components.Entities.Categories.Fruits
{
    public class Fruit : ItemFood
    {
        public string? Grade { get; private set; }
        public string? FormRelease { get; private set; }
        public string? CoolingMode { get; private set; }
        public string? SkinColor { get; private set; }
        public List<SalesLine> SalesWeights { get; private set; } = new();
    }
}
