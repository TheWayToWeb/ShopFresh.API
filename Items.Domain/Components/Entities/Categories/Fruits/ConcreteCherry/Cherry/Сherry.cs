using Items.Domain.Components.Entities.Categories.Fruits.ConcreteCherry;
using FruitSelf = Items.Domain.Components.Entities.Categories.Fruits.Fruit.Fruit;

namespace Items.Domain.Components.Entities.Categories.Fruits.ConcreteCherry.Cherry
{
    public class Сherry : FruitSelf
    {
        public string Grade { get; set; } = string.Empty;

        public Сherry(GrowCherry cherry)
        {
            PersonId = cherry.personId;
            ItemId = cherry.itemId;
            Price = cherry.price;
            ImagePath = cherry.imagePath;
            Maker = cherry.maker;
            MinTemp = cherry.minTemp;
            MaxTemp = cherry.maxTemp;
            Protein = cherry.protein;
            Fat = cherry.fat;
            Sugar = cherry.sugar;
            Energy = cherry.energy;
            CountInPackage = cherry.countInPackage;
            CreatedDate = cherry.createdDate;
            Weight = cherry.weight;
            CoolingMode = cherry.coolingMode;
            IsFarmer = cherry.isFarmer;
        }
    }
}
