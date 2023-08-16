using Items.Domain.Components.Entities.Categories.Common;

namespace Items.Domain.Components.Entities.Categories.ViscousDairyProduct
{
    public class ViscousDairyProduct : ItemFood
    {
        public string? Taste { get; private set; }
        public string? FatContent { get; private set; }
    }
}
