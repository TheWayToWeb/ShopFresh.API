using SelfVegetable = Items.Domain.Entities.Categories.Vegetables.Vegetable.Vegetable;

namespace Items.Domain.Entities.Categories.Vegetables.ConcreteTomato.Tomato
{
    public class Tomato : SelfVegetable
    {
        public string? SkinColor { get; private set; }

        public Tomato(BuildTomato builderTomato)
        {
            PersonId = builderTomato.PersonId;
            ItemId = builderTomato.ItemId;
            Price = builderTomato.Price;
            ImagePath = builderTomato.ImagePath;
            Maker = builderTomato.Maker;
            MinTemp = builderTomato.MinTemp;
            MaxTemp = builderTomato.MaxTemp;
            Protein = builderTomato.Protein;
            Fat = builderTomato.Fat;
            Sugar = builderTomato.Sugar;
            Energy = builderTomato.Energy;
            CountInPackage = builderTomato.CountInPackage;
            CreatedDate = builderTomato.CreatedDate;
            Weight = builderTomato.Weight;
            IsFarmer = builderTomato.IsFarmer;
            CoolingMode = builderTomato.CoolingMode;
            Grade = builderTomato.Grade;
            IsSlicingShape = builderTomato.IsSlicngShape;
            SkinColor = builderTomato.SkinColor;
        }
    }
}
