using FruitSelf = Items.Domain.Entities.Categories.Fruits.Fruit.Fruit;

namespace Items.Domain.Entities.Categories.Fruits.ConcreteGrape.Grape
{
    public class Grape : FruitSelf
    {
        public string Grade { get; set; } = string.Empty;

        public Grape(GrowGrape grape)
        {
            PersonId = grape.personId;
            ItemId = grape.itemId;
            Price = grape.price;
            ImagePath = grape.imagePath;
            Maker = grape.maker;
            MinTemp = grape.minTemp;
            MaxTemp = grape.maxTemp;
            Protein = grape.protein;
            Fat = grape.fat;
            Sugar = grape.sugar;
            Energy = grape.energy;
            CountInPackage = grape.countInPackage;
            CreatedDate = grape.createdDate;
            Weight = grape.weight;
            IsFarmer = grape.isFarmer;
            CoolingMode = grape.coolingMode;
            Grade = grape.grade;
        }
    }
}
