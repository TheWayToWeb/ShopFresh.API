using DomainDrinkEnergy = Items.Domain.Components.Entities.Categories.Drinks.ConcreteDrinkEnergy.DrinkEnergy.DrinkEnergy;

namespace Items.Domain.Components.Entities.Categories.Drinks.ConcreteDrinkEnergy
{

    public interface IMakerDrinkEnergy
    {
        public DomainDrinkEnergy CreateDrinkEnergy();
    }
}


