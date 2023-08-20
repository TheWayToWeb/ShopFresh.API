using Items.Domain.Components.Entities.Common;

namespace Items.Domain.Components.Entities.Cream
{
    public class Cream : ItemFood
    {
        public string? Taste { get; private set; }
        public List<FatContentProduct> CreamFats { get; private set; } = new();
        public string? MilkProcessing { get; private set; }
        public string? PrimaryProduct { get; private set; }

    }
}
