using Items.Domain.Products.Category.SubCategory.FreshGroup.FreshItem;

namespace Items.Domain.Products.Category.SubCategory.ItemCategory.Items.Frozen_food.Ice_cream
{
    public class IceCream : Item
    {
        private readonly List<string> _taste = new List<string>();
        public List<string> Taste { get { return _taste; } }
        public string? Kind { get; set; }
        public string? Shape { get; set; }
        public string? Addition { get; set; }
    }
}
