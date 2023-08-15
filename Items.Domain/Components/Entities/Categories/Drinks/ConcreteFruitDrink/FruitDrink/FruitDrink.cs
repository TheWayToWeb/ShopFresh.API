using Items.Domain.Components.Entities.Categories.Common;
using DomainJuice = Items.Domain.Components.Entities.Categories.Drinks.ConcreteJuice.Juice.Juice;

namespace Items.Domain.Components.Entities.Categories.Drinks.ConcreteFruitDrink.FruitDrink
{
    public class FruitDrink : DomainJuice
    {
        public FruitDrink(Guid personId, Guid itemId, string itemName, int price, string imagePath, string maker, int minTemp, int maxTemp, float protein, float fat, float sugar, float energy, int countInPackage, int createdDate, List<Taste> tastes, List<Capacity> capacities, bool isChilled) : base(personId, itemId, itemName, price, imagePath, maker, minTemp, maxTemp, protein, fat, sugar, energy, countInPackage, createdDate, tastes, capacities, isChilled)
        {
        }
    }
}
