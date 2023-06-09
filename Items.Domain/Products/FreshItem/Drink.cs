using Items.Domain.Products.Template;

namespace Items.Domain.Products.FreshItem
{
    public abstract class Drink : Item
    {
        public List<Capacity>? Capacity { get; set; } = new();
        public string? CoolingMode { get; set; }
    }
}
