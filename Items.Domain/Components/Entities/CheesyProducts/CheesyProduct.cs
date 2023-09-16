using Items.Domain.Components.Entities.Common;

namespace Items.Domain.Components.Entities.CheesyProducts
{
    public class CheesyProduct : ItemFood
    {
        public string? Taste { get; private set; }
    }
}
