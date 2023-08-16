namespace Items.Domain.Components.Entities.Categories.Common
{
    public class ItemFood : Item
    {
        // CategoryId
        // Category Category

        public bool IsFarmer { get; private set; }
        public float Protein { get; private set; }
        public float Fat { get; private set; }
        public float Sugar { get; private set; }
        public float Energy { get; private set; }
        public int CreatedDate { get; private set; }
        public int MinTemp { get; private set; }
        public int MaxTemp { get; private set; }

    }
}
