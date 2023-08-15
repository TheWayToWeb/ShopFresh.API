using Items.Domain.Components.Entities.Categories.Fruits.ConcreteBluBerry;
using FruitSelf = Items.Domain.Components.Entities.Categories.Fruits.Fruit.Fruit;

namespace Items.Domain.Components.Entities.Categories.Fruits.ConcreteBluBerry.BlueBerry
{
    public class Blueberry : FruitSelf
    {
        public string Grade { get; set; } = string.Empty;

        public Blueberry(GrowBlueBerry blueberry)
        {
            PersonId = blueberry.personId;
            ItemId = blueberry.itemId;
            Price = blueberry.price;
            ImagePath = blueberry.imagePath;
            Maker = blueberry.maker;
            MinTemp = blueberry.minTemp;
            MaxTemp = blueberry.maxTemp;
            Protein = blueberry.protein;
            Fat = blueberry.fat;
            Sugar = blueberry.sugar;
            Energy = blueberry.energy;
            CountInPackage = blueberry.countInPackage;
            Weight = blueberry.weight;
            CoolingMode = blueberry.coolingMode;
            IsFarmer = blueberry.isFarmer;
            Grade = blueberry.grade;
        }
    }
}
