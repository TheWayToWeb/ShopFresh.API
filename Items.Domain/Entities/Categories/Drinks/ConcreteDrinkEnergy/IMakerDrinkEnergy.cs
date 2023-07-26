using DomainDrinkEnergy = Items.Domain.Models.Categories.Drinks.ConcreteDrinkEnergy.DrinkEnergy.DrinkEnergy;

namespace Items.Domain.Models.Categories.Drinks.ConcreteDrinkEnergy {

    public interface IMakerDrinkEnergy
    {
        public DomainDrinkEnergy CreateDrinkEnergy();
    }
}


