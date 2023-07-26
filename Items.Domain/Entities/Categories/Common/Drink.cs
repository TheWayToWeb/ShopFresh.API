namespace Items.Domain.Models.Categories.Common
{
    public abstract class Drink : Item
    {
        public List<Taste>? Tastes { get; set; } = new();
        public List<Capacity>? Capacities { get; set; } = new();
        public bool IsChilled { get; set; }
    }
}
