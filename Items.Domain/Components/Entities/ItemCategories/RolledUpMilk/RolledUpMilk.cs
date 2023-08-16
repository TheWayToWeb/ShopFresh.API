using Items.Domain.Components.Entities.Categories.Common;

namespace Items.Domain.Components.Entities.Categories.RolledUpMilk
{
    public class RolledUpMilk : ItemFood
    {
        public string? Taste { get; private set; }
        public List<FatContentProduct> FatContents { get; private set; } = new();
        public string? KindProduct { get; private set; }
        public string? FormRelease { get; private set; }
    }
}
