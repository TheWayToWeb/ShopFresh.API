namespace Items.Domain.Products.Category.SubCategory.FreshGroup.FreshItem.Mushrooms
{
    public class Mushroom : Item
    {
        public string? Kind { get; set; }
        public string? Shape { get; set; }
        public float CountProtein { get; set; }
        public int Weight { get; set; }
        public List<int> Weights { get; set; } = new();
        public bool IsInterest { get; set; }
    }
}
