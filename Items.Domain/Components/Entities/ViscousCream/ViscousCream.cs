using Items.Domain.Components.Entities.Common;

namespace Items.Domain.Components.Entities.ViscousCream
{
    public class ViscousCream : ItemFood
    {
        public List<ProductTaste> Taste { get; private set; } = new();
        public List<FatContentProduct> FatContents { get; private set; } = new();
        public string? PrimaryProduct { get; private set; }
    }
}
