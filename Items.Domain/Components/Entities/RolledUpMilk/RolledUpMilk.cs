using Items.Domain.Components.Entities.Common;

namespace Items.Domain.Components.Entities.RolledUpMilk
{
    public class RolledUpMilk : ItemFood
    {
        public string? Taste { get; private set; }
        public List<FatContentProduct> FatContents { get; private set; } = new();
        public string? KindProduct { get; private set; }
        public string? FormRelease { get; private set; }
    }
}
