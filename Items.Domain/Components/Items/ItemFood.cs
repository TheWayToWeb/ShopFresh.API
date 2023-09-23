namespace Items.Domain.Components.Items
{
    public class ItemFood : Item
    {
        public bool IsFarmer { get; private set; }
        public float Protein { get; private set; }
        public float Fat { get; private set; }
        public float Sugar { get; private set; }
        public float Energy { get; private set; }
        public int CreatedDate { get; private set; }
        public float MinTemp { get; private set; }
        public float MaxTemp { get; private set; }
    }
}
