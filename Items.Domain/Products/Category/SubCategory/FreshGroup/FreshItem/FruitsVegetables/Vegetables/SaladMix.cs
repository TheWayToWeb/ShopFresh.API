namespace Items.Domain.Products.Category.SubCategory.FreshGroup.FreshItem.FruitsVegetables.Vegetables
{
    public class SaladMix : Vegetable
    {
        public string? Grade { get; set; }
        public List<Salad> SaladGrades { get; set; } = new();
    }
}
