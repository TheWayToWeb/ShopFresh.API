using SelfVegetable = Items.Domain.Entities.Categories.Vegetables.Vegetable.Vegetable;
using Line = Items.Domain.Entities.Categories.Common.Range;

namespace Items.Domain.Entities.Categories.Vegetables.BuilderCabbage.Cabbage
{
    public class Сabbage : SelfVegetable
    {
        public List<Line> SaleWeights { get; private set; } = new();

        public Сabbage(BuildCabbage builderCabbage)
        {
            PersonId = builderCabbage.PersonId;
            ItemId = builderCabbage.ItemId;
            Price = builderCabbage.Price;
            ImagePath = builderCabbage.ImagePath;
            Maker = builderCabbage.Maker;
            MinTemp = builderCabbage.MinTemp;
            MaxTemp = builderCabbage.MaxTemp;
            Protein = builderCabbage.Protein;
            Fat = builderCabbage.Fat;
            Sugar = builderCabbage.Sugar;
            Energy = builderCabbage.Energy;
            CountInPackage = builderCabbage.CountInPackage;
            CreatedDate = builderCabbage.CreatedDate;
            IsFarmer = builderCabbage.IsFarmer;
            CoolingMode = builderCabbage.CoolingMode;
            Grade = builderCabbage.Grade;
            IsSlicingShape = builderCabbage.IsSlicingShape;
            SaleWeights = builderCabbage.SaleWeights;
        }
    }
}
