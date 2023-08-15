using DomainFruitDrink = Items.Domain.Components.Entities.Categories.Drinks.ConcreteFruitDrink.FruitDrink.FruitDrink;

namespace Items.Domain.Components.Entities.Categories.Drinks.ConcreteFruitDrink
{
    public interface IMakerFruitDrink
    {
        public DomainFruitDrink CreateFruitDrink();
    }
}
