using ExoticFruitDomain = Items.Domain.Models.Categories.Fruits.ConcreteExoticFruit.ExoticFruit.ExoticFruit;

namespace Items.Domain.Models.Categories.Fruits.ConcreteExoticFruit
{
    public class GrowExoticFruit : IGrowerExoticFruit
    {
        public Guid personId { get; private set; }
        public Guid itemId { get; private set; }
        public string itemName { get; private set; }
        public int price { get; private set; } = 0;
        public string imagePath { get; private set; } = string.Empty;
        public string maker { get; private set; } = string.Empty;
        public int minTemp { get; private set; } = 0;
        public int maxTemp { get; private set; } = 0;
        public float protein { get; private set; } = 0;
        public float fat { get; private set; } = 0;
        public float sugar { get; private set; } = 0;
        public float energy { get; private set; } = 0;
        public int countInPackage { get; private set; } = 1;
        public int createdDate { get; private set; } = 12;
        public float weight { get; private set; }
        public string coolingMode { get; private set; } = "Fresh";
        public bool isFarmer { get; private set; } = false;
        public string grade { get; private set; } = string.Empty;

        public GrowExoticFruit(Guid personId) {
            this.personId = personId;
            this.itemId = Guid.NewGuid();
            this.itemName = string.Empty;
            this.weight = 1;
        }

        public GrowExoticFruit(Guid personId, string itemName, float weight) {
            this.personId = personId;
            this.itemId = Guid.NewGuid();
            this.itemName = itemName;
            this.weight = weight;
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
        public void CoolingMode(string value) => coolingMode = value;
        public void Grade(string value) => grade = value;

        public ExoticFruitDomain CreateExoticFruit() {
            return new ExoticFruitDomain(
                personId,
                itemId,
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
                coolingMode,
                grade
            );
        }
    }
}
