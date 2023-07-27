using FruitSelf = Items.Domain.Entities.Categories.Fruits.Fruit.Fruit;

namespace Items.Domain.Entities.Categories.Fruits.ConcreteSeaBucthorn.SeaBucthorn
{
    public class SeaBucthorn : FruitSelf
    {
        public SeaBucthorn(GrowSeaBucthorn seaBucthorn)
        {
            PersonId = seaBucthorn.personId;
            ItemId = seaBucthorn.itemId;
            Price = seaBucthorn.price;
            ImagePath = seaBucthorn.imagePath;
            Maker = seaBucthorn.maker;
            MinTemp = seaBucthorn.minTemp;
            MaxTemp = seaBucthorn.maxTemp;
            Protein = seaBucthorn.protein;
            Fat = seaBucthorn.fat;
            Sugar = seaBucthorn.sugar;
            Energy = seaBucthorn.energy;
            CountInPackage = seaBucthorn.countInPackage;
            CreatedDate = seaBucthorn.createdDate;
            Weight = seaBucthorn.weight;
            CoolingMode = seaBucthorn.coolingMode;
            IsFarmer = seaBucthorn.isFarmer;
        }
    }
}
