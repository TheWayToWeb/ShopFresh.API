namespace Items.Domain.Products.FreshItem.FruitsVegetables.Vegetables
{
    public class VegetableMix : Eat
    {
        public List<Vegetable> Vegetables { get; set; } = new();
    }
}
