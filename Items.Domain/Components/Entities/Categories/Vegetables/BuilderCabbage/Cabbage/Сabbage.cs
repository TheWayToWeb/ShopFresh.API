using SelfVegetable = Items.Domain.Components.Entities.Categories.Vegetables.Vegetable.Vegetable;
using SalesRange = Items.Domain.Components.Entities.Categories.Vegetables.Common.SalesRange;

namespace Items.Domain.Components.Entities.Categories.Vegetables.BuilderCabbage.Cabbage
{
    public class Сabbage : SelfVegetable
    {
        public List<SalesRange> SaleWeights { get; private set; } = new();

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
