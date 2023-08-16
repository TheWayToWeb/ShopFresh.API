using FruitSelf = Items.Domain.Components.Entities.Categories.Fruits.Fruit.Fruit;

namespace Items.Domain.Components.Entities.Categories.Fruits.BuilderBluBerry.BlueBerry
{
    public class Blueberry : FruitSelf
    {
        public Blueberry(BuildBlueberry builderBlueberry)
        {
            PersonId = builderBlueberry.PersonId;
            ItemId = builderBlueberry.ItemId;
            Price = builderBlueberry.Price;
            ImagePath = builderBlueberry.ImagePath;
            Maker = builderBlueberry.Maker;
            MinTemp = builderBlueberry.MinTemp;
            MaxTemp = builderBlueberry.Maxtemp;
            Protein = builderBlueberry.Protein;
            Fat = builderBlueberry.Fat;
            Sugar = builderBlueberry.Sugar;
            Energy = builderBlueberry.Energy;
            CountInPackage = builderBlueberry.CountInPackage;
            CreatedDate = builderBlueberry.CreatedDate;
            Weight = builderBlueberry.Weight;
            CoolingMode = builderBlueberry.CoolingMode;
        }
    }
}
