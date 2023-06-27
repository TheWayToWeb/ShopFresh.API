using Items.Domain.Products.Templates;

namespace Items.Domain.Products.FreshItem.Drinks.MakingEnergyDrink
{
    public class EnergyDrink : Drink
    {
        public List<State>? State { get; set; } = new();
        public float Coffein { get; set; }
    }
}
