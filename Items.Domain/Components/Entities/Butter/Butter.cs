using Items.Domain.Components.Entities.Common;

namespace Items.Domain.Components.Entities.Butter
{
    public class Butter : ItemFood
    {
        public List<ProductTaste> Taste { get; private set; } = new();
        public List<FatContentProduct> FatContents { get; private set; } = new();
        public bool IsVegan { get; private set; }
    }
}
