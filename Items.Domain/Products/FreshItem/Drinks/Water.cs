using Items.Domain.Products.Template;

namespace Items.Domain.Products.FreshItem.Drinks
{
    public class Water : Drink
    {
        public List<Taste>? Taste { get; set; } = new();
        public bool IsChilled { get; set; }
        public bool IsCarbonation { get; set; }
        public string? Purpose { get; set; }
    }
}
