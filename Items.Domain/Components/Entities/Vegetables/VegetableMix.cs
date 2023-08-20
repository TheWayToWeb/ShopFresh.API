namespace Items.Domain.Components.Entities.Vegetables
{
    public class VegetableMix : Vegetable
    {
        public List<Vegetable> Vegetables { get; private set; } = new();
    }
}
