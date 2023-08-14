using Line = Items.Domain.Entities.Categories.Common.Range;
using VegetableSelf = Items.Domain.Entities.Categories.Vegetables.Vegetable.Vegetable;

namespace Items.Domain.Entities.Categories.Vegetables.ConcretePotato.Potato
{
    public class Potato : VegetableSelf
    {
        public List<Line> SaleWeights { get; private set; } = new();
        public bool IsWash { get; private set; }

        public Potato(BuildPotato builderPotato)
        {
            PersonId = builderPotato.PersonId;
            ItemId = builderPotato.ItemId;
            Price = builderPotato.Price;
            ImagePath = builderPotato.ImagePath;
            Maker = builderPotato.Maker;
            MinTemp = builderPotato.MinTemp;
            MaxTemp = builderPotato.MaxTemp;
            Protein = builderPotato.Protein;
            Fat = builderPotato.Fat;
            Sugar = builderPotato.Sugar;
            Energy = builderPotato.Energy;
            CountInPackage = builderPotato.CountInPackage;
            CreatedDate = builderPotato.CreatedDate;
            InitWeight(builderPotato.Weight);
            IsFarmer = builderPotato.IsFarmer;
            CoolingMode = builderPotato.CoolingMode;
            Grade = builderPotato.Grade;
            IsSlicingShape = builderPotato.IsSlicingShape;
            SaleWeights = builderPotato.SaleWeights;
            IsWash = builderPotato.IsWash;
        }

        public void InitWeight(float? value)
        {
            if (value is null) return;
            Weight = (float)value;
        }
    }
}
