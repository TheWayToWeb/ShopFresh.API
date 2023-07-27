using FruitSelf = Items.Domain.Entities.Categories.Fruits.Fruit.Fruit;

namespace Items.Domain.Entities.Categories.Fruits.ConcreteRaspberry.Raspberry
{
    public class Raspberry : FruitSelf
    {
        public Raspberry(GrowRaspberry raspberry)
        {
            PersonId = raspberry.personId;
            ItemId = raspberry.itemId;
            Price = raspberry.price;
            ImagePath = raspberry.imagePath;
            Maker = raspberry.maker;
            MinTemp = raspberry.minTemp;
            MaxTemp = raspberry.maxTemp;
            Protein = raspberry.protein;
            Fat = raspberry.fat;
            Sugar = raspberry.sugar;
            Energy = raspberry.energy;
            CountInPackage = raspberry.countInPackage;
            CreatedDate = raspberry.createdDate;
            Weight = raspberry.weight;
            CoolingMode = raspberry.coolingMode;
            IsFarmer = raspberry.isFarmer;
        }
    }
}
