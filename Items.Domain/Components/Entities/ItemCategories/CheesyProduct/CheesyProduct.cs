using Items.Domain.Components.Entities.Categories.Common;

namespace Items.Domain.Components.Entities.Categories.CheesyProduct
{
    public class CheesyProduct : ItemFood
    {
        public List<ProductTaste> Tastes { get; private set; } = new();
        public string? FatContent { get; private set; }
        public string? KindRelease { get; private set; }
    }
}
