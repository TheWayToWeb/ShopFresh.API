using Items.Domain.Components.Entities.Common;

namespace Items.Domain.Components.Entities.ViscousDairyProduct
{
    public class ViscousDairyProduct : ItemFood
    {
        public string? Taste { get; private set; }
        public string? FatContent { get; private set; }
    }
}
