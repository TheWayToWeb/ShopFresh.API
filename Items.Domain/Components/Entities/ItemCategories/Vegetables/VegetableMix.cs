namespace Items.Domain.Components.Entities.Categories.Vegetables
{
    public class VegetableMix : Vegetable
    {
        public List<Vegetable> Vegetables { get; private set; } = new();
    }
}
