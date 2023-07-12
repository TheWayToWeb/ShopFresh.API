using DomainFruitDrink = Items.Domain.Models.Categories.Drinks.ConcreteFruitDrink.FruitDrink.FruitDrink;

namespace Items.Domain.Models.ConcreteFruitDrink
{
    public interface IMakerFruitDrink
    {
        public DomainFruitDrink CreateFruitDrink();
    }
}
