namespace Items.Domain.Products.FreshItem.Bakery.FactoryGingerbread
{
    public class MakeGingerbread : Baker
    {
        public Guid PersonId { get; set; }
        public Guid ItemId { get; set; }
        private string? _itemName { get; set; } = "";
        private int _price { get; set; } = 0;
        private string? _imagePath { get; set; } = "";
        private string? _maker { get; set; } = "";
        private int _minTemp { get; set; } = 0;
        private int _maxTemp { get; set; } = 0;
        private float _protein { get; set; } = 0;
        private float _fat { get; set; } = 0;
        private float _sugar { get; set; } = 0;
        private float _energy { get; set; } = 0;
        private int _countInPackage { get; set; } = 0;
        private int _productExpiryDate { get; set; } = 0;
        private float? _weight { get; set; } = null;
        private bool _isFarmer { get; set; } = false;
        private string? _coolingMode { get; set; } = "";
        private string? _productBakeryKind { get; set; } = "";
        private string? _productKindItSelf { get; set; } = "";

        public MakeGingerbread() {
        }

        public MakeGingerbread(Guid personId, string? itemName, int price, string? imagePath) {
            PersonId = personId;
            ItemId = Guid.NewGuid();
            _itemName = itemName;
            _price = price;
            _imagePath = imagePath;
        }

        public void SetItemName(string value) {
            _itemName = value;
        }

        public string GetItemName() {
            return _itemName!;
        }

        public void SetPrice(int value) {
            _price = value;
        }

        public int GetPrice() {
            return _price;
        }

        public void SetImagePath(string value) {
            _imagePath = value;
        }

        public string GetImagePath() {
            return _imagePath!;
        }

        public void SetMaker(string value) {
            _maker = value;
        }

        public string GetMaker() {
            return _maker!;
        }

        public void SetMinTemp(int value) {
            _minTemp = value;
        }

        public int GetMinTemp() {
            return _minTemp;
        }

        public void SetMaxTemp(int value) {
            _maxTemp = value;
        }

        public int GetMaxTemp() {
            return _maxTemp;
        }

        public void SetProtein(float value) {
            _protein = value;
        }

        public float GetProtein() {
            return _protein;
        }

        public void SetFat(float value) {
            _fat = value;
        }

        public float GetFat() {
            return _fat;
        }

        public void SetSugar(float value) {
            _sugar = value;
        }

        public float GetSugar() {
            return _sugar;
        }

        public void SetEnergy(float value) {
            _energy = value;
        }

        public float GetEnergy() {
            return _energy;
        }

        public void SetCountInPackage(int value) {
            _countInPackage = value;
        }

        public int GetCountInPackage() {
            return _countInPackage;
        }

        public void SetProductExpiryDate(int value) {
            _productExpiryDate = value;
        }

        public int GetProductExpiryDate() {
            return _productExpiryDate;
        }

        public void SetWeight(float value) {
            _weight = value;
        }

        public float? GetWeight() {
            return _weight;
        }

        public void SetIsFarmer(bool value) {
            _isFarmer = value;
        }

        public bool GetIsFarmer() {
            return _isFarmer;
        }

        public void SetCoolingMode(string value) {
            _coolingMode = value;
        }

        public string CoolingMode() {
            return _coolingMode!;
        }

        public void SetProductBakeryKind(string value) {
            _productBakeryKind = value;
        }

        public string GetProductBakeryKind() {
            return _productBakeryKind!;
        }

        public void SetProductKindItSelf(string value) {
            _productKindItSelf = value;
        }

        public override Gingerbread CreateGingerbread()
        {
            return new Gingerbread(PersonId, ItemId, _itemName, _price, _imagePath);
        }
    }
}
