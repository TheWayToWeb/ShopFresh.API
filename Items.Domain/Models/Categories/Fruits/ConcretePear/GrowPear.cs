namespace Items.Domain.Models.Categories.Fruits.ConcretePear
{
    public class GrowPear : IGrowerPear
    {
        public Guid personId { get; private set; }
        public Guid itemId { get; private set; }
        public string itemName { get; private set; }
        public int price { get; private set; }
        public string imagePath { get; private set; }
        public string maker { get; private set; }
        public int minTemp { get; private set; }
        public int maxTemp { get; private set; }
        public float protein { get; private set; }
        public float fat { get; private set; }
        public float sugar { get; private set; }
        public float energy { get; private set; }
        public int countInPackage { get; private set; }
        public int createdDate { get; private set; }
        public float weight { get; private set; }
        public string coolingMode { get; private set; }
        public bool isFarmer { get; private set; }
        public string grade { get; private set; }

        public GrowPear(Guid personId) { }
        public GrowPear(Guid personId, string itemName, float weight) {
        }

        public void ItemName(string value) => itemName = value;
        public void Price(int value) => price = value;
    }
}
