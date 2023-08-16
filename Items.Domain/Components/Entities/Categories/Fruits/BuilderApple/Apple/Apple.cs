using SelfFruit = Items.Domain.Components.Entities.Categories.Fruits.Fruit.Fruit;
using SalesLine = Items.Domain.Components.Entities.Categories.Fruits.Common.SalesLine;

namespace Items.Domain.Components.Entities.Categories.Fruits.BuilderApple.Apple
{
    public class Apple : SelfFruit
    {
        public List<SalesLine> SaleWeights { get; private set; } = new();

        public Apple(BuildApple builderApple)
        {
            PersonId = builderApple.PersonId;
            ItemId = builderApple.ItemId;
            Price = builderApple.Price;
            ImagePath = builderApple.ImagePath;
            Maker = builderApple.Maker;
            MinTemp = builderApple.MinTemp;
            MaxTemp = builderApple.MaxTemp;
            Protein = builderApple.Protein;
            Fat = builderApple.Fat;
            Sugar = builderApple.Sugar;
            Energy = builderApple.Energy;
            CountInPackage = builderApple.CountInPackage;
            CreatedDate = builderApple.CreatedDate;
            InitWeight(builderApple.Weight);
            CoolingMode = builderApple.CoolingMode;
            IsFarmer = builderApple.IsFarmer;
            Grade = builderApple.Grade;
            IsSlicingShape = builderApple.IsSlicingShape;
            Description = builderApple.Description;
            SaleWeights = builderApple.SalesWeights;
        }

        public void InitWeight(float? value)
        {
            if (value is null) return;
            Weight = (float)value;
        }
    }
}
