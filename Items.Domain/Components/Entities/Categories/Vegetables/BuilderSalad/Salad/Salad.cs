using SelfVegetable = Items.Domain.Components.Entities.Categories.Vegetables.Vegetable.Vegetable;

namespace Items.Domain.Components.Entities.Categories.Vegetables.BuilderSalad.Salad
{
    public class Salad : SelfVegetable
    {
        public Salad(BuildSalad builderSalad)
        {
            PersonId = builderSalad.PersonId;
            ItemId = builderSalad.ItemId;
            Price = builderSalad.Price;
            ImagePath = builderSalad.ImagePath;
            Maker = builderSalad.Maker;
            MinTemp = builderSalad.MinTemp;
            MaxTemp = builderSalad.MaxTemp;
            Protein = builderSalad.Protein;
            Fat = builderSalad.Fat;
            Sugar = builderSalad.Sugar;
            Energy = builderSalad.Energy;
            CountInPackage = builderSalad.CountInPackage;
            CreatedDate = builderSalad.CreatedDate;
            Weight = builderSalad.Weight;
            IsFarmer = builderSalad.IsFarmer;
            CoolingMode = builderSalad.CoolingMode;
            Grade = builderSalad.Grade;
            IsSlicingShape = builderSalad.IsSlicingShape;
        }
    }
}
