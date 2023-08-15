using Items.Domain.Components.Entities.Categories.Fruits.ConcreteExoticFruit;
using FruitSelf = Items.Domain.Components.Entities.Categories.Fruits.Fruit.Fruit;

namespace Items.Domain.Components.Entities.Categories.Fruits.ConcreteExoticFruit.ExoticFruit
{
    public class ExoticFruit : FruitSelf
    {
        public string Grade { get; set; } = string.Empty;

        public ExoticFruit(GrowExoticFruit exoticFruit)
        {
            PersonId = exoticFruit.personId;
            ItemId = exoticFruit.itemId;
            Price = exoticFruit.price;
            ImagePath = exoticFruit.imagePath;
            Maker = exoticFruit.maker;
            MinTemp = exoticFruit.minTemp;
            MaxTemp = exoticFruit.maxTemp;
            Protein = exoticFruit.protein;
            Fat = exoticFruit.fat;
            Sugar = exoticFruit.sugar;
            Energy = exoticFruit.energy;
            CountInPackage = exoticFruit.countInPackage;
            CreatedDate = exoticFruit.createdDate;
            Weight = exoticFruit.weight;
            CoolingMode = exoticFruit.coolingMode;
            Grade = exoticFruit.grade;
        }
    }
}
