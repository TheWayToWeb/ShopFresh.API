using Items.Domain.Models.Categories.Common;

namespace Items.Domain.Models.Categories.Fruits.ConcreteGrape.Grape
{
    public class Grape : Fruit
    {
        public string? Grade { get; set; }

        public Grape(
            Guid personId,
            Guid itemId,
            string itemName,
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
            bool isFarmer,
            string coolingMode,
            string grade
        ) {
            PersonId = personId;
            ItemId = itemId;
            ItemName = itemName;
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
            IsFarmer = isFarmer;
            CoolingMode = coolingMode;
            Grade = grade;
        }
    }
}
