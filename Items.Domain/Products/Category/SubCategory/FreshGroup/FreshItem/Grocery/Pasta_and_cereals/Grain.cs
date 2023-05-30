using Items.Domain.Products.Category.SubCategory.FreshGroup.FreshItem;

namespace Items.Domain.Products.Category.SubCategory.ItemCategory.Items.Grocery.Pasta_and_cereals
{
    public class Grain : Item
    {
        private readonly List<int> _weight = new List<int>();
        public List<int> Weight { get { return _weight; } }
        public int Units { get; set; }
        public string? Kind { get; set; }
        public string? Shape { get; set; }
    }
}
