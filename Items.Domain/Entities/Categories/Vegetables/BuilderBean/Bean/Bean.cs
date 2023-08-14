using SelfVegetable = Items.Domain.Entities.Categories.Vegetables.Vegetable.Vegetable;

namespace Items.Domain.Entities.Categories.Vegetables.BuilderBean.Bean
{
    public class Bean : SelfVegetable
    {
        public Bean(BuildBean builderBean)
        {
            PersonId = builderBean.PersonId;
            ItemId = builderBean.ItemId;
            Price = builderBean.Price;
            ImagePath = builderBean.ImagePath;
            Maker = builderBean.Maker;
            MinTemp = builderBean.MinTemp;
            MinTemp = builderBean.MaxTemp;
            Protein = builderBean.Protein;
            Fat = builderBean.Fat;
            Sugar = builderBean.Sugar;
            Energy = builderBean.Energy;
            CountInPackage = builderBean.CountInPackage;
            CreatedDate = builderBean.CreatedDate;
            Weight = builderBean.Weight;
            CoolingMode = builderBean.CoolingMode;
            Grade = builderBean.Grade;
            IsSlicingShape = builderBean.IsSlicingShape;
        }
    }
}
