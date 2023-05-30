namespace Items.Domain.Products.Category.SubCategory.FreshGroup.FreshItem.FruitsVegetables.Vegetables
{
    public class Potato : Eatable
    {
        public string? Grade { get; set; }
        public List<Range> SaleWeights { get; set; } = new();
        public bool IsWash { get; set; }

    }
}
