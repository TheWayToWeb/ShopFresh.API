using Items.Domain.Components.Entities.Categories.Vegetables.BuilderBroccoli;
using SelfVegetable = Items.Domain.Components.Entities.Categories.Vegetables.Vegetable.Vegetable;

namespace Items.Domain.Components.Entities.Categories.Vegetables.BuilderBroccoli.Broccoli
{
    public class Broccoli : SelfVegetable
    {
        public Broccoli(BuildBroccoli builderBroccoli)
        {
            PersonId = builderBroccoli.PersonId;
            ItemId = builderBroccoli.ItemId;
            Price = builderBroccoli.Price;
            ImagePath = builderBroccoli.ImagePath;
            Maker = builderBroccoli.Maker;
            MinTemp = builderBroccoli.MinTemp;
            MaxTemp = builderBroccoli.MaxTemp;
            Protein = builderBroccoli.Protein;
            Fat = builderBroccoli.Fat;
            Sugar = builderBroccoli.Sugar;
            Energy = builderBroccoli.Energy;
            CountInPackage = builderBroccoli.CountInPackage;
            CreatedDate = builderBroccoli.CreatedDate;
            Weight = builderBroccoli.Weight;
            CoolingMode = builderBroccoli.CoolingMode;
            Grade = builderBroccoli.Grade;
            IsSlicingShape = builderBroccoli.IsSlicingShape;
        }
    }
}
