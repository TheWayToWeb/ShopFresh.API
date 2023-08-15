using Items.Domain.Components.Entities.Categories.Fruits.ConcreteBlackBerry;
using FruitSelf = Items.Domain.Components.Entities.Categories.Fruits.Fruit.Fruit;

namespace Items.Domain.Components.Entities.Categories.Fruits.ConcreteBlackBerry.BlackBerry
{
    public class Blackberry : FruitSelf
    {
        public Blackberry(GrowBlackberry blackberry)
        {
            PersonId = blackberry.personId;
            ItemId = blackberry.itemId;
            Price = blackberry.price;
            ImagePath = blackberry.imagePath;
            Maker = blackberry.maker;
            MinTemp = blackberry.minTemp;
            MaxTemp = blackberry.maxTemp;
            Protein = blackberry.protein;
            Fat = blackberry.fat;
            Sugar = blackberry.sugar;
            Energy = blackberry.energy;
            CountInPackage = blackberry.countInPackage;
            CreatedDate = blackberry.createdDate;
            Weight = blackberry.weight;
            CoolingMode = blackberry.coolingMode;
            IsFarmer = blackberry.isFarmer;
        }
    }
}
