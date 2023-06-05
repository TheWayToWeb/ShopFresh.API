using Items.Domain.Products.FreshItem;

namespace Items.Domain.Products.FreshItem.Grocery.Pasta_and_cereals
{
    public class FastCook : Item
    {
        public string? Taste { get; set; }
        public int Weight { get; set; }
        public int EnergyValue { get; set; }
    }
}
