using BakeryShop = Items.Domain.Components.Entities.Categories.Common.Bakery;

namespace Items.Domain.Components.Entities.Bakery.FancyCake
{
    public class FancyCake : BakeryShop
    {
        public string? ProductKindSelf { get; set; }
        public string? ProductTypeSelf { get; set; }

        public FancyCake(
            Guid personId,
            Guid itemId,
            string itemName,
            int price,
            string imagePath,
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
            string productKindSelf,
            string productTypeSelf
        )
        {
            PersonId = personId;
            ItemId = itemId;
            ItemName = itemName;
            Price = price;
            ImagePath = imagePath;
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
            ProductKindSelf = productKindSelf;
            ProductTypeSelf = productTypeSelf;
        }
    }
}
