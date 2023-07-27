using FruitSelf = Items.Domain.Entities.Categories.Fruits.Fruit.Fruit;

namespace Items.Domain.Entities.Categories.Fruits.ConcreteExoticFruit.ExoticFruit
{
    public class ExoticFruit : FruitSelf
    {
        public string Grade { get; set; } = string.Empty;

        public ExoticFruit(
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
            string grade
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
            Grade = grade;
        }
    }
}
