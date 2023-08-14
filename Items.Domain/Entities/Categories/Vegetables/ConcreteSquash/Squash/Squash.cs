using SelfVegetable = Items.Domain.Entities.Categories.Vegetables.Vegetable.Vegetable;
using Line = Items.Domain.Entities.Categories.Common.Range;

namespace Items.Domain.Entities.Categories.Vegetables.ConcreteSquash.Squash
{
    public class Squash : SelfVegetable
    {
        public List<Line> SaleWeights { get; private set; } = new();

        public Squash(BuildSquash builderSquash)
        {
            PersonId = builderSquash.PersonId;
            ItemId = builderSquash.ItemId;
            Price = builderSquash.Price;
            ImagePath = builderSquash.ImagePath;
            Maker = builderSquash.Maker;
            MinTemp = builderSquash.MinTemp;
            MaxTemp = builderSquash.MaxTemp;
            Protein = builderSquash.Protein;
            Fat = builderSquash.Fat;
            Sugar = builderSquash.Sugar;
            Energy = builderSquash.Energy;
            CountInPackage = builderSquash.CountInPackage;
            CreatedDate = builderSquash.CreatedDate;
            IsFarmer = builderSquash.IsFarmer;
            CoolingMode = builderSquash.CoolingMode;
            Grade = builderSquash.Grade;
            IsSlicingShape = builderSquash.IsSlicingShape;
            SaleWeights = builderSquash.SaleWeights;
        }
    }
}
