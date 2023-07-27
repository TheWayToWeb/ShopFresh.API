using FruitSelf = Items.Domain.Entities.Categories.Fruits.Fruit.Fruit;

namespace Items.Domain.Entities.Categories.Fruits.ConcreteCitrus.Citrus
{
    public class Citrus : FruitSelf
    {
        public string Grade { get; set; } = string.Empty;

        public Citrus(GrowCitrus citrus)
        {
            PersonId = citrus.personId;
            ItemId = citrus.itemId;
            Price = citrus.price;
            ImagePath = citrus.imagePath;
            Maker = citrus.maker;
            MinTemp = citrus.minTemp;
            MaxTemp = citrus.maxTemp;
            Protein = citrus.protein;
            Fat = citrus.fat;
            Sugar = citrus.sugar;
            Energy = citrus.energy;
            CountInPackage = citrus.countInPackage;
            CreatedDate = citrus.createdDate;
            Weight = citrus.weight;
            CoolingMode = citrus.coolingMode;
            IsFarmer = citrus.isFarmer;
            Grade = citrus.grade;
        }
    }
}
