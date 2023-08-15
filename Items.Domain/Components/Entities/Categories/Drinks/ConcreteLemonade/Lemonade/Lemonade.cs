using Items.Domain.Components.Entities.Categories.Common;
using Items.Domain.Components.Entities.Categories.Drinks.ConcreteWater.Water;

namespace Items.Domain.Components.Entities.Categories.Drinks.ConcreteLemonade.Lemonade
{
    public class Lemonade : Water
    {
        public Lemonade(Guid personId, Guid itemId, string itemName, int price, string imagePath, string maker, int minTemp, int maxTemp, float protein, float fat, float sugar, float energy, int countInPackage, int createdDate, List<Taste> tastes, List<Capacity> capacities, bool isChilled, bool isSparkling, string purpose) : base(personId, itemId, itemName, price, imagePath, maker, minTemp, maxTemp, protein, fat, sugar, energy, countInPackage, createdDate, tastes, capacities, isChilled, isSparkling, purpose)
        {
        }
    }
}
