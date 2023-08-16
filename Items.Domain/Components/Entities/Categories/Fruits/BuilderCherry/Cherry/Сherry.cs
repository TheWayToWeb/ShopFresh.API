using SelfFruit = Items.Domain.Components.Entities.Categories.Fruits.Fruit.Fruit;

namespace Items.Domain.Components.Entities.Categories.Fruits.BuilderCherry.Cherry
{
    public class Сherry : SelfFruit
    {
        public Сherry(BuildCherry builderCherry)
        {
            PersonId = builderCherry.PersonId;
            ItemId = builderCherry.ItemId;
            Price = builderCherry.Price;
            ImagePath = builderCherry.ImagePath;
            Maker = builderCherry.Maker;
            MinTemp = builderCherry.MinTemp;
            MaxTemp = builderCherry.Maxtemp;
            Protein = builderCherry.Protein;
            Fat = builderCherry.Fat;
            Sugar = builderCherry.Sugar;
            Energy = builderCherry.Energy;
            CountInPackage = builderCherry.CountInPackage;
            CreatedDate = builderCherry.CreatedDate;
            Weight = builderCherry.Weight;
            IsFarmer = builderCherry.IsFarmer;
            CoolingMode = builderCherry.CoolingMode;
            Grade = builderCherry.Grade;
            IsSlicingShape = builderCherry.IsSlicingShape;
            Description = builderCherry.Description;
        }
    }
}
