using FruitSelf = Items.Domain.Components.Entities.Categories.Fruits.Fruit.Fruit;
using SalesLine = Items.Domain.Components.Entities.Categories.Fruits.Common.SalesLine;

namespace Items.Domain.Components.Entities.Categories.Fruits.BuilderBanana.Banana
{
    public class Banana : FruitSelf
    {
        public List<SalesLine> SaleWeights { get; set; } = new();

        public Banana(BuildBanana builderBanana)
        {
            PersonId = builderBanana.PersonId;
            ItemId = builderBanana.ItemId;
            Price = builderBanana.Price;
            ImagePath = builderBanana.ImagePath;
            Maker = builderBanana.Maker;
            MinTemp = builderBanana.MinTemp;
            MaxTemp = builderBanana.MaxTemp;
            Protein = builderBanana.Protein;
            Fat = builderBanana.Fat;
            Sugar = builderBanana.Sugar;
            Energy = builderBanana.Energy;
            CountInPackage = builderBanana.CountInPackage;
            CreatedDate = builderBanana.CreatedDate;
            CoolingMode = builderBanana.CoolingMode;
            IsFarmer = builderBanana.IsFarmer;
            Grade = builderBanana.Grade;
            SaleWeights = builderBanana.SalesWeights;
        }
    }
}
