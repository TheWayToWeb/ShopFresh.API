using Items.Domain.Components.Entities.Categories.Common;

namespace Items.Domain.Components.Entities.Categories.Butter
{
    public class Butter : ItemFood
    {
        public List<ProductTaste> Taste { get; private set; } = new();
        public List<FatContentProduct> FatContents { get; private set; } = new();
        public bool IsVegan { get; private set; }
    }
}
