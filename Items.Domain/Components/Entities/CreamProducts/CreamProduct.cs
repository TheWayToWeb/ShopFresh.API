using Items.Domain.Components.Entities.Common;

namespace Items.Domain.Components.Entities.CreamProducts
{
    public class CreamProduct : ItemFood
    {
        public List<FlavorName> Taste { get; private set; } = new();
        public List<FatContentProduct> FatContents { get; private set; } = new();
        public string? PrimaryProduct { get; private set; }
    }
}
