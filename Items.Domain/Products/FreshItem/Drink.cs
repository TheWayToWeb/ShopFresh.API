using Items.Domain.Products.Template;

namespace Items.Domain.Products.FreshItem
{
    public abstract class Drink : Item
    {
        public List<Taste>? Tastes { get; set; } = new();
        public List<Capacity>? Capacities { get; set; } = new();
        public bool IsChilled { get; set; }
    }
}
