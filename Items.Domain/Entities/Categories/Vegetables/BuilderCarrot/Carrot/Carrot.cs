using SelfVegetable = Items.Domain.Entities.Categories.Vegetables.Vegetable.Vegetable;
using Line = Items.Domain.Entities.Categories.Common.Range;

namespace Items.Domain.Entities.Categories.Vegetables.BuilderCarrot.Carrot
{
    public class Carrot : SelfVegetable
    {
        public List<Line> SaleWeights { get; private set; } = new();
        public bool IsWash { get; private set; }

        public Carrot(BuildCarrot builderCarrot)
        {
            PersonId = builderCarrot.PersonId;
            ItemId = builderCarrot.ItemId;
            Price = builderCarrot.Price;
            ImagePath = builderCarrot.ImagePath;
            Maker = builderCarrot.Maker;
            MinTemp = builderCarrot.MinTemp;
            MaxTemp = builderCarrot.MaxTemp;
            Protein = builderCarrot.Protein;
            Fat = builderCarrot.Fat;
            Sugar = builderCarrot.Sugar;
            Energy = builderCarrot.Energy;
            CountInPackage = builderCarrot.CountInPackage;
            CreatedDate = builderCarrot.CreatedDate;
            CoolingMode = builderCarrot.CoolingMode;
            IsFarmer = builderCarrot.IsFarmer;
            Grade = builderCarrot.Grade;
            IsSlicingShape = builderCarrot.IsSlicingShape;
            IsWash = builderCarrot.IsWash;
            SaleWeights = builderCarrot.SaleWeights;
        }
    }
}
