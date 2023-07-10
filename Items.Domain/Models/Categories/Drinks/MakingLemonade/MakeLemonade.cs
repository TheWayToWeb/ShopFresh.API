using Items.Domain.Models.Categories.Common;

namespace Items.Domain.Models.Categories.Drinks.MakingLemonade
{
    public class MakeLemonade : MakerLemonade
    {
        public Guid PersonId { get; private set; }
        public Guid ItemId { get; private set; }
        public string _itemName { get; private set; } = "";
        public int _price { get; private set; } = 0;
        public string _imagePath { get; private set; } = "";
        public string _maker { get; private set; } = "";
        public int _minTemp { get; private set; } = 0;
        public int _maxTemp { get; private set; } = 0;
        public float _protein { get; private set; } = 0;
        public float _fat { get; private set; } = 0;
        public float _sugar { get; private set; } = 0;
        public float _energy { get; private set; } = 0;
        public int _countInPackage { get; private set; } = 0;
        public int _createdDate { get; private set; } = 0;
        public List<Taste> _tastes { get; private set; } = new();
        public List<Capacity> _capacities { get; private set; } = new();
        public bool _isChilled { get; private set; } = false;
        public bool _isSparkling { get; private set; } = false;
        public string _purpose { get; private set; } = "";

        public MakeLemonade() { }

        public MakeLemonade(Guid personId, string itemName, int price, string imagePath)
        {
            PersonId = personId;
            ItemId = Guid.NewGuid();
            _itemName = itemName;
            _price = price;
            _imagePath = imagePath;
        }

        public void ItemName(string value) => _itemName = value;
        public void Price(int value) => _price = value;
        public void ImagePath(string value) => _imagePath = value;
        public void Maker(string value) => _maker = value;
        public void MinTemp(int value) => _minTemp = value;
        public void MaxTemp(int value) => _maxTemp = value;
        public void Protein(float value) => _protein = value;
        public void Fat(float value) => _fat = value;
        public void Sugar(float value) => _sugar = value;
        public void Energy(float value) => _energy = value;
        public void CountInPackage(int value) => _countInPackage = value;
        public void CreatedDate(int value) => _createdDate = value;
        public void Taste(List<Taste> value) => _tastes.AddRange(value);
        public void Capacity(List<Capacity> value) => _capacities.AddRange(value);
        public void IsChilled(bool value) => _isChilled = value;
        public void IsSparkling(bool value) => _isSparkling = value;
        public void IsPurpose(string value) => _purpose = value;

        public override Lemonade CreateLemonade()
        {
            return new Lemonade(PersonId, ItemId, _itemName, _price, _imagePath);
        }
    }
}
