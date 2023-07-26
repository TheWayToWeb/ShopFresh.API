using BakeryShop = Items.Domain.Models.Categories.Common.Bakery;

namespace Items.Domain.Models.Categories.Bakery.Cookie
{
    public class Cookie : BakeryShop
    {
        public string? ProductKindSelf { get; set; }

        public Cookie(
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
            string productBakeryKind,
            string addition,
            string productKindSelf
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
            ProductBakeryKind = productBakeryKind;
            Addition = addition;
            ProductKindSelf = productKindSelf;
        }
    }
}
