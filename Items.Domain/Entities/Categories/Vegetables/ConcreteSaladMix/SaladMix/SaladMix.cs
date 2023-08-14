using Salad = Items.Domain.Entities.Categories.Vegetables.ConcreteSalad.Salad.Salad;
using VegetableSelf = Items.Domain.Entities.Categories.Vegetables.Vegetable.Vegetable;

namespace Items.Domain.Entities.Categories.Vegetables.ConcreteSaladMix.SaladMix
{
    public class SaladMix : VegetableSelf
    {
        public List<Salad> GreeneryKinds { get; private set; } = new();

        public SaladMix(BuildSaladMix builderSaladMix)
        {
            PersonId = builderSaladMix.PersonId;
            ItemId = builderSaladMix.ItemId;
            Price = builderSaladMix.Price;
            ImagePath = builderSaladMix.ImagePath;
            Maker = builderSaladMix.Maker;
            MinTemp = builderSaladMix.MinTemp;
            MaxTemp = builderSaladMix.MaxTemp;
            Protein = builderSaladMix.Protein;
            Fat = builderSaladMix.Fat;
            Sugar = builderSaladMix.Sugar;
            Energy = builderSaladMix.Energy;
            CountInPackage = builderSaladMix.CountInPackage;
            CreatedDate = builderSaladMix.CreatedDate;
            Weight = builderSaladMix.Weight;
            CoolingMode = builderSaladMix.CoolingMode;
            Grade = builderSaladMix.Grade;
            IsSlicingShape = builderSaladMix.IsSlicingShape;
            GreeneryKinds = builderSaladMix.GreeneryKinds;
        }   
    }
}
