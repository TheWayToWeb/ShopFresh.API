using Items.Domain.Models.Categories.Vegetables;

namespace Items.Domain.Entities.Categories.Vegetables.ConcreteBean.Bean
{
    public class Bean : Vegetable
    {
        public Bean(
            Guid personId,
            Guid itemId,
            int price,
            string imagePath,
            string maker,
            int minTemp,
            int maxTemp,
            float protein,
            float fat,
            float sugar,
            float energy,
            int countInPackage,
            int createdDate,
            float weight,
            string coolingMode,
            bool isFarmer,
            string grade,
            bool isSlicingShape
        ) {
            PersonId = personId;
            ItemId = itemId;
            Price = price;
            ImagePath = imagePath;
            Maker = maker;
            MinTemp = minTemp;
            MaxTemp = maxTemp;
            Protein = protein;
            Fat = fat;
            Sugar = sugar;
            Energy = energy;
            CountInPackage = countInPackage;
            CreatedDate = createdDate;
            Weight = weight;
            CoolingMode = coolingMode;
            IsFarmer = isFarmer;
            Grade = grade;
            IsSlicingShape = isSlicingShape;
        }
    }
}
