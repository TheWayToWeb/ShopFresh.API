using SelfFruit = Items.Domain.Components.Entities.Categories.Fruits.Fruit.Fruit;
using SalesLine = Items.Domain.Components.Entities.Categories.Fruits.Common.SalesLine;

namespace Items.Domain.Components.Entities.Categories.Fruits.BuilderCitrus.Citrus
{
    public class Citrus : SelfFruit
    {
        public List<SalesLine> SalesWeights { get; private set; } = new();

        public Citrus(BuildCitrus builderCitrus)
        {
            PersonId = builderCitrus.PersonId;
            ItemId = builderCitrus.ItemId;
            Price = builderCitrus.Price;
            ImagePath = builderCitrus.ImagePath;
            Maker = builderCitrus.Maker;
            MinTemp = builderCitrus.MinTemp;
            MaxTemp = builderCitrus.MaxTemp;
            Protein = builderCitrus.Protein;
            Fat = builderCitrus.Fat;
            Sugar = builderCitrus.Sugar;
            Energy = builderCitrus.Energy;
            CountInPackage = builderCitrus.CountInPackage;
            CreatedDate = builderCitrus.CreatedDate;
            InitWeight(builderCitrus.Weight);
            CoolingMode = builderCitrus.CoolingMode;
            Grade = builderCitrus.Grade;
            IsSlicingShape = builderCitrus.IsSlicingShape;
            Description = builderCitrus.Description;
            SalesWeights = builderCitrus.SaleWeights;
        }

        public void InitWeight(float? value)
        {
            if (value is null) return;
            Weight = (float)value;
        }
    }
}
