using SelfVegetable = Items.Domain.Components.Entities.Categories.Vegetables.Vegetable.Vegetable;

namespace Items.Domain.Components.Entities.Categories.Vegetables.BuilderCauliflower.Cauliflower
{
    public class Cauliflower : SelfVegetable
    {
        public string? SkinColor { get; private set; }

        public Cauliflower(BuildCauliflower builderCauliflower)
        {
            PersonId = builderCauliflower.PersonId;
            ItemId = builderCauliflower.ItemId;
            Price = builderCauliflower.Price;
            ImagePath = builderCauliflower.ImagePath;
            Maker = builderCauliflower.Maker;
            MinTemp = builderCauliflower.MinTemp;
            MaxTemp = builderCauliflower.MaxTemp;
            Protein = builderCauliflower.Protein;
            Fat = builderCauliflower.Fat;
            Sugar = builderCauliflower.Sugar;
            Energy = builderCauliflower.Energy;
            CountInPackage = builderCauliflower.CountInPackage;
            CreatedDate = builderCauliflower.CreatedDate;
            Weight = builderCauliflower.Weight;
            CoolingMode = builderCauliflower.CoolingMode;
            Grade = builderCauliflower.Grade;
            IsSlicingShape = builderCauliflower.IsSlicingShape;
            SkinColor = builderCauliflower.SkinColor;
        }
    }
}
