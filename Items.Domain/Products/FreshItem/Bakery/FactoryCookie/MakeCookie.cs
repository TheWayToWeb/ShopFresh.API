namespace Items.Domain.Products.FreshItem.Bakery.FactoryCookie
{
    public class MakeCookie : Cooker
    {
        public Guid PersonId { get; set; }
        public Guid ItemId { get; set; }
        public string? ItemName { get; set; }
        public int Price { get; set; }
        public string? ImagePath { get; set; }
        public string? Maker { get; set; }
        public int MinTemp { get; set; }
        public int MaxTemp { get; set; }
        public float Protein { get; set; }
        public float Fat { get; set; }
        public float Sugar { get; set; }
        public float Energy { get; set; }
        public int CountInPackage { get; set; }
        public int ProductExpiryDate { get; set; }
        public float? Weight { get; set; }
        public string? CoolingMode { get; set; }
        public bool IsFarmer { get; set; }
        public string? ProductBakeryKind { get; set; }
        public string? Addition { get; set; }
        public string? ProductKindItSelf { get; set; }

        public MakeCookie(
            Guid personId,
            Guid itemId,
            string? itemName,
            int price,
            string? imagePath,
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
            string? coolingMode,
            bool isFarmer,
            string? productBakeryKind,
            string? addition,
            string? productKindItSelf
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

        public override Bakery Create()
        {
            return new Cookie(
                PersonId,
                ItemId,
                ItemName!,
                Price,
                ImagePath!,
                Maker,
                MinTemp,
                MaxTemp,
                Protein,
                Fat,
                Sugar,
                Energy,
                CountInPackage,
                ProductExpiryDate,
                Weight,
                CoolingMode!,
                IsFarmer,
                ProductBakeryKind!,
                Addition!,
                ProductKindItSelf!
                );
        }
    }
}
