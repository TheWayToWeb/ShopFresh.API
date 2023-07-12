using Items.Domain.Models.Categories.Common;
using DomainCoffee = Items.Domain.Models.Categories.Drinks.ConcreteCoffee.Coffee.Coffee;

namespace Items.Domain.Models.Categories.Drinks.ConcreteCoffee
{
    public class CoffeeMake : IMakerCoffee
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
        public List<Taste> tastes { get; private set; } = new();
        public List<Capacity> capacities { get; private set; } = new();
        public bool isChilled { get; private set; } = false;
        public string typeCoffee { get; private set; } = "";
        public string kindOfCoffee { get; private set; } = "";
        public string consistency { get; private set; } = "";
        public string composition { get; private set; } = "";
        public string tasteIntensity { get; private set; } = "";
        public bool isCoffeinFree { get; private set; } = false;

        public CoffeeMake() { }

        public CoffeeMake(Guid personId, string itemName, int price, string imagePath)
        {
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
        public void Taste(List<Taste> value) => tastes.AddRange(value);
        public void Capacity(List<Capacity> value) => capacities.AddRange(value);
        public void IsChilled(bool value) => isChilled = value;
        public void TypeCoffee(string value) => typeCoffee = value;
        public void KindOfCoffee(string value) => kindOfCoffee = value;
        public void Consistency(string value) => consistency = value;
        public void Composition(string value) => composition = value;
        public void TasteIntensity(string value) => tasteIntensity = value;
        public void IsCoffeinFree(bool value) => isCoffeinFree = value;

        public DomainCoffee CreateCoffee()
        {
            return new DomainCoffee(
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
                tastes,
                capacities,
                isChilled,
                typeCoffee,
                kindOfCoffee,
                consistency,
                composition,
                tasteIntensity,
                isCoffeinFree
            );
        }
    }
}
