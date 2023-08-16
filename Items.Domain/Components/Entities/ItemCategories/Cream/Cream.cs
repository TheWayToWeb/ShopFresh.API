using Items.Domain.Components.Entities.Categories.Common;

namespace Items.Domain.Components.Entities.Categories.Cream
{
    public class Cream : ItemFood
    {
        public string? Taste { get; private set; }
        public List<FatContentProduct> CreamFats { get; private set; } = new();
        public string? MilkProcessing { get; private set; }
        public string? PrimaryProduct { get; private set; }

    }
}
