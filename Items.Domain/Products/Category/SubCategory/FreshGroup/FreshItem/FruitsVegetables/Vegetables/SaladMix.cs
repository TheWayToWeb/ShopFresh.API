namespace Items.Domain.Products.Category.SubCategory.FreshGroup.FreshItem.FruitsVegetables.Vegetables
{
    public class SaladMix : Eatable
    {
        public string? Grade { get; set; }
        // сделать перечисление
        public List<string> SaladKinds { get; set; } = new();
    }
}
