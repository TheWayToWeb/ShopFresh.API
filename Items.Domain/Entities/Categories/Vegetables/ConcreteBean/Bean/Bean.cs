using Items.Domain.Models.Categories.Vegetables;

namespace Items.Domain.Entities.Categories.Vegetables.ConcreteBean.Bean
{
    public class Bean : Vegetable
    {
        public Bean(GrowBean bean)
        {
            PersonId = bean.personId;
            ItemId = bean.itemId;
            Price = bean.price;
            ImagePath = bean.imagePath;
            Maker = bean.maker;
            MinTemp = bean.minTemp;
            MaxTemp = bean.maxTemp;
            Protein = bean.protein;
            Fat = bean.fat;
            Sugar = bean.sugar;
            Energy = bean.energy;
            CountInPackage = bean.countInPackage;
            CreatedDate = bean.createdDate;
            Weight = bean.weight;
            CoolingMode = bean.coolingMode;
            IsFarmer = bean.isFarmer;
            Grade = bean.grade;
            IsSlicingShape = bean.isSlicingShape;
        }
    }
}
