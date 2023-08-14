using SelfVegetable = Items.Domain.Entities.Categories.Vegetables.Vegetable.Vegetable;

namespace Items.Domain.Entities.Categories.Vegetables.ConcreteRedis.Redis
{
    public class Redis : SelfVegetable
    {
        public string? SkinColor { get; private set; }

        public Redis(BuildRedis builderRedis)
        {
            PersonId = builderRedis.PersonId;
            ItemId = builderRedis.ItemId;
            Price = builderRedis.Price;
            ImagePath = builderRedis.ImagePath;
            Maker = builderRedis.Maker;
            MinTemp = builderRedis.MinTemp;
            MaxTemp = builderRedis.MaxTemp;
            Protein = builderRedis.Protein;
            Fat = builderRedis.Fat;
            Sugar = builderRedis.Sugar;
            Energy = builderRedis.Energy;
            CountInPackage = builderRedis.CountInPackage;
            CreatedDate = builderRedis.CreatedDate;
            Weight = builderRedis.Weight;
            IsFarmer = builderRedis.IsFarmer;
            CoolingMode = builderRedis.CoolingMode;
            Grade = builderRedis.Grade;
            IsSlicingShape = builderRedis.IsSlicingShape;
            SkinColor = builderRedis.SkinColor;
        }
    }
}
