using Items.Domain.Models.Categories.Common;

namespace Items.Domain.Models.Water
{
    public class MakeWater : IMakerWater
    {
        public Guid PersonId { get; private set; }
        public Guid ItemId { get; private set; }
        public string  itemName { get; private set; } = "";
        public int  price { get; private set; } = 0;
        public string  imagePath { get; private set; } = "";
        public string  maker { get; private set; } = "";
        public int  minTemp { get; private set; } = 0;
        public int  maxTemp { get; private set; } = 0;
        public float  protein { get; private set; } = 0;
        public float  fat { get; private set; } = 0;
        public float  sugar { get; private set; } = 0;
        public float  energy { get; private set; } = 0;
        public int  countInPackage { get; private set; } = 0;
        public int  createdDate { get; private set; } = 0;
        public List<Taste>  tastes { get; private set; } = new();
        public List<Capacity>  capacities { get; private set; } = new();
        public bool  isChilled { get; private set; } = false;
        public bool  isSparkling { get; private set; } = false;
        public string  purpose { get; private set; } = "";

        public MakeWater() {
        }

        public MakeWater(Guid personId, string itemName, int price, string imagePath)
        {
                PersonId = personId;
                ItemId = Guid.NewGuid();
            this.itemName = itemName;
            this.price = price;
            this.imagePath = imagePath;
        }

        public void ItemName(string value) =>  itemName = value;
        public void Price(int value) =>  price = value;
        public void ImagePath(string value) =>  imagePath = value;
        public void Maker(string value) =>  maker = value;
        public void MinTemp(int value) =>  minTemp = value;
        public void Maxtemp(int value) =>  maxTemp = value;
        public void Protein(float value) =>  protein = value;
        public void Fat(float value) =>  fat = value;
        public void Sugar(float value) =>  sugar = value;
        public void Energy(float value) =>  energy = value;
        public void CountInPackage(int value) =>  countInPackage = value;
        public void CreatedDate(int value) =>  createdDate = value;
        public void Taste(List<Taste> value) =>  tastes.AddRange(value);
        public void Capacity(List<Capacity> value) =>  capacities.AddRange(value);
        public void IsChilled(bool value) =>  isChilled = value;
        public void IsSparkling(bool value) =>  isSparkling = value;
        public void Purpose(string value) =>  purpose = value;


        public Water CreateWater() {
            return new Water(

            );
        }
    }
}
