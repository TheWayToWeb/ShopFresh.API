namespace Items.Domain.Products.FreshItem.FruitsVegetables.Vegetables
{
    public class Mushroom : Eatable
    {
        public string? Kind { get; set; }
        public List<Range> SaleWeights { get; set; } = new();
    }
}
