using Items.Domain.Products.Templates;

namespace Items.Domain.Products.FreshItem.Drinks
{
    public class EnergyDrink : Water
    {
        public List<State>? State { get; set; } = new();
        public float Coffein { get; set; }
    }
}
