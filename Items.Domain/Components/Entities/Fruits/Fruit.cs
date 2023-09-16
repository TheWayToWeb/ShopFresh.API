using Items.Domain.Components.Entities.Common;

namespace Items.Domain.Components.Entities.Fruits
{
    public class Fruit : ItemFood
    {
        public string? Kind { get; private set; }
        public string? FormRelease { get; private set; }
        public string? Grade { get; private set; }
        public string? CoolingMode { get; private set; }
        public List<SalesRange> SaleWeights { get; set; } = new();
    }
}
