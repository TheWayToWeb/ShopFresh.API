namespace Items.Domain.Models.Categories.Grocery.Pasta_and_cereals
{
    public class Pasta : Item
    {
        private readonly List<int> _weight = new List<int>();
        public List<int> Weight { get { return _weight; } }
        public readonly List<string> _kind = new List<string>();
        public List<string> Kind { get { return _kind; } }
        public string? Shape { get; set; }
        public string? Type { get; set; }
        public int Units { get; set; }
    }
}
