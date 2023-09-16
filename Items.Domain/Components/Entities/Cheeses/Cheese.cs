using Items.Domain.Components.Entities.Common;

namespace Items.Domain.Components.Entities.Cheeses
{
    public class Cheese : ItemFood
    {
        public string? Kind { get; set; }
        public string? Grade { get; set; }
        public string? FormRelease { get; set; }
        public List<SalesRange> SaleWeights { get; set; } = new();
    }
}
