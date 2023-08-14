using SelfVegetable = Items.Domain.Entities.Categories.Vegetables.Vegetable.Vegetable;

namespace Items.Domain.Entities.Categories.Vegetables.BuilderBeet.Beet
{
    public class Beet : SelfVegetable
    {
        public Beet(BuildBeet builderBeet)
        {
            PersonId = builderBeet.PersonId;
            ItemId = builderBeet.ItemId;
            Price = builderBeet.Price;
            ImagePath = builderBeet.ImagePath;
            Maker = builderBeet.Maker;
            MinTemp = builderBeet.MinTemp;
            MaxTemp = builderBeet.MaxTemp;
            Protein = builderBeet.Protein;
            Fat = builderBeet.Fat;
            Sugar = builderBeet.Sugar;
            Energy = builderBeet.Energy;
            CountInPackage = builderBeet.CountInPackage;
            CreatedDate = builderBeet.CreatedDate;
            Weight = builderBeet.Weight;
            CoolingMode = builderBeet.CoolingMode;
            IsFarmer = builderBeet.IsFarmer;
            Grade = builderBeet.Grade;
            IsSlicingShape = builderBeet.IsSlicingShape;
        }
    }
}
