using Items.Domain.Products.Template;

namespace Items.Domain.Products.FreshItem
{
    public abstract class Drink : Item
    {
        public List<Taste>? Taste { get; set; } = new();
        public List<Capacity>? Capacity { get; set; } = new();
        public bool IsChilled { get; set; }
    }
}
