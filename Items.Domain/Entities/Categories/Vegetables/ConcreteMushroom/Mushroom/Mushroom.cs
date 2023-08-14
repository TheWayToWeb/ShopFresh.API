using SelfVegetable = Items.Domain.Entities.Categories.Vegetables.Vegetable.Vegetable;

namespace Items.Domain.Entities.Categories.Vegetables.ConcreteMushroom.Mushroom
{
    public class Mushroom : SelfVegetable
    {
        public Mushroom(BuildMushroom builderMushroom)
        {
            PersonId = builderMushroom.PersonId;
            ItemId = builderMushroom.ItemId;
            Price = builderMushroom.Price;
            ImagePath = builderMushroom.ImagePath;
            Maker = builderMushroom.Maker;
            MinTemp = builderMushroom.MinTemp;
            MaxTemp = builderMushroom.MaxTemp;
            Protein = builderMushroom.Protein;
            Fat = builderMushroom.Fat;
            Sugar = builderMushroom.Sugar;
            Energy = builderMushroom.Energy;
            CountInPackage = builderMushroom.CountInPackage;
            CreatedDate = builderMushroom.CreatedDate;
            Weight = builderMushroom.Weight;
            IsFarmer = builderMushroom.IsFarmer;
            CoolingMode = builderMushroom.CoolingMode;
            Grade = builderMushroom.Grade;
            IsSlicingShape = builderMushroom.IsSlicingShape;
        }
    }
}
