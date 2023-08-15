using Items.Domain.Components.Entities.Categories.Common;
using SelfVegetable = Items.Domain.Components.Entities.Categories.Vegetables.Vegetable.Vegetable;

namespace Items.Domain.Components.Entities.Categories.Vegetables.BuilderVegetableMix.VegetableMix
{
    public class VegetableMix : Eat
    {
        public List<SelfVegetable> Vegetables { get; set; } = new();

        public VegetableMix(BuildVegetableMix builderVegetableMix)
        {
            PersonId = builderVegetableMix.PersonId;
            ItemId = builderVegetableMix.ItemId;
            Price = builderVegetableMix.Price;
            ImagePath = builderVegetableMix.ImagePath;
            Maker = builderVegetableMix.Maker;
            MinTemp = builderVegetableMix.MinTemp;
            MaxTemp = builderVegetableMix.MaxTemp;
            Protein = builderVegetableMix.Protein;
            Fat = builderVegetableMix.Fat;
            Sugar = builderVegetableMix.Sugar;
            Energy = builderVegetableMix.Energy;
            CountInPackage = builderVegetableMix.CountInPackage;
            CreatedDate = builderVegetableMix.CreatedDate;
            Weight = builderVegetableMix.Weight;
            CoolingMode = builderVegetableMix.CoolingMode;
            Vegetables = builderVegetableMix.Vegetables;
        }
    }
}
