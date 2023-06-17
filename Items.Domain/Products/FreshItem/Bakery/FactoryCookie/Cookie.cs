namespace Items.Domain.Products.FreshItem.Bakery.FactoryCookie
{
    public class Cookie : Bakery
    {
        public Cookie(
            Guid personId,
            Guid itemId,
            string itemName,
            int price,
            string imagePath,
            string? maker,
            int minTemp,
            int maxTemp,
            float protein,
            float fat,
            float sugar,
            float energy,
            int countInPackage,
            int productExpiryDate,
            float? weight,
            string coolingMode,
            bool isFarmer,
            string productBakeryKind,
            string addition,
            string productKindItSelf
            )
        {
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
            ProductExpiryDate = productExpiryDate;
            Weight = weight;
            CoolingMode = coolingMode;
            IsFarmer = isFarmer;
            ProductBakeryKind = productBakeryKind;
            Addition = addition;
            ProductKindItSelf = productKindItSelf;
        }

        public string? ProductKindItSelf { get; set; }
    }
}
