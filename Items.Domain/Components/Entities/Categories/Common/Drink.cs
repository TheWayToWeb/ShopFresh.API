using Items.Domain.Components.Entities.Categories.MilkProducts.Common;

namespace Items.Domain.Components.Entities.Categories.Common
{
    public abstract class Drink : Item
    {
        public List<ProductTaste>? Tastes { get; set; } = new();
        public List<SoldCapacity>? Capacities { get; set; } = new();
        public bool IsChilled { get; set; }
    }
}
