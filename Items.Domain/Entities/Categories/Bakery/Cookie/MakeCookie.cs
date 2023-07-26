namespace Items.Domain.Models.Categories.Bakery.Cookie
{
    public class MakeCookie : IMakerCookie
    {
        public Guid PersonId { get; private set; }
        public Guid ItemId { get; private set; }
        public string itemName { get; private set; } = "";
        public int price { get; private set; } = 0;
        public string imagePath { get; private set; } = "";
        public string maker { get; private set; } = "";
        public int minTemp { get; private set; } = 0;
        public int maxTemp { get; private set; } = 0;
        public float protein { get; private set; } = 0;
        public float fat { get; private set; } = 0;
        public float sugar { get; private set; } = 0;
        public float energy { get; private set; } = 0;
        public int countInPackage { get; private set; } = 0;
        public int createdDate { get; private set; } = 0;
        public float weight { get; private set; } = 1;
        public bool isFarmer { get; private set; } = false;
        public string coolingMode { get; private set; } = "";
        public string productBakeryKind { get; private set; } = "";
        public string addition { get; private set; } = "";
        public string productKindSelf { get; private set; } = "";

        public MakeCookie() { }

        public MakeCookie(
            Guid personId,
            string itemName,
            int price,
            string imagePath
        ) {
                PersonId = personId;
                ItemId = Guid.NewGuid();
            this.itemName = itemName;
            this.price = price;
            this.imagePath = imagePath;
        }

        public void ItemName(string value) => itemName = value;
        public void Price(int value) => price = value;
        public void ImagePath(string value) => imagePath = value;
        public void Maker(string value) => maker = value;
        public void MinTemp(int value) => minTemp = value;
        public void MaxTemp(int value) => maxTemp = value;
        public void Protein(float value) => protein = value;
        public void Fat(float value) => fat = value;
        public void Sugar(float value) => sugar = value;
        public void Energy(float value) => energy = value;
        public void CountInPackage(int value) => countInPackage = value;
        public void CreatedDate(int value) => createdDate = value;
        public void Weight(float value) => weight = value;
        public void IsFarmer(bool value) => isFarmer = value;
        public void CoolingMode(string value) => coolingMode = value;
        public void ProductBakeryKind(string value) => productBakeryKind = value;
        public void Addition(string value) => addition = value;
        public void ProductKindSelf(string value) => productKindSelf = value;
        
        public Cookie CreateCookie() {
            return new Cookie(
                PersonId,
                ItemId,
                itemName,
                price,
                imagePath,
                maker,
                minTemp,
                maxTemp,
                protein,
                fat,
                sugar,
                energy,
                countInPackage,
                createdDate,
                weight,
                isFarmer,
                coolingMode,
                productBakeryKind,
                addition,
                productKindSelf
            );
        }
    }
}
