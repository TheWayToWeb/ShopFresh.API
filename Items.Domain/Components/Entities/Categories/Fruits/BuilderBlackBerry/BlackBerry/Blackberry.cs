using FruitSelf = Items.Domain.Components.Entities.Categories.Fruits.Fruit.Fruit;

namespace Items.Domain.Components.Entities.Categories.Fruits.BuilderBlackBerry.BlackBerry
{
    public class Blackberry : FruitSelf
    {
        public Blackberry(BuildBlackberry builderBalckberry)
        {
            PersonId = builderBalckberry.PersonId;
            ItemId = builderBalckberry.ItemId;
            Price = builderBalckberry.Price;
            ImagePath = builderBalckberry.ImagePath;
            Maker = builderBalckberry.Maker;
            MinTemp = builderBalckberry.MinTemp;
            MaxTemp = builderBalckberry.MaxTemp;
            Protein = builderBalckberry.Protein;
            Fat = builderBalckberry.Fat;
            Sugar = builderBalckberry.Sugar;
            Energy = builderBalckberry.Energy;
            CountInPackage = builderBalckberry.CountInPackage;
            CreatedDate = builderBalckberry.CreatedDate;
            Weight = builderBalckberry.Weight;
            CoolingMode = builderBalckberry.CoolingMode;
        }
    }
}
