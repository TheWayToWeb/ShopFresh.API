using Items.Domain.Models.Categories.Common;
using Range = Items.Domain.Models.Categories.Common.Range;

namespace Items.Domain.Models.Categories.Fruits.ConcreteBanana.Banana
{
    public class Banana : Fruit
    {
        public string? Grade { get; set; }
        public List<Range> SaleWeights { get; set; } = new();

        public Banana(
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
            string coolingMode,
            bool isFarmer,
            string grade,
            List<Range> saleWeights
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
            CoolingMode = coolingMode;
            IsFarmer = isFarmer;
            Grade = grade;
            SaleWeights = saleWeights;
        }
    }
}
