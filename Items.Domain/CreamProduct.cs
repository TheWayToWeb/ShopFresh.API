using Items.Domain.Products.Category.SubCategory.FreshGroup.FreshItem;

namespace Items.Domain
{
    // кефир, творог, сметана
    public class CreamProduct : Item
    {
        private readonly List<string> _taste = new List<string>();
        public List<string> Taste { get { return _taste; } }
        private readonly List<float> _fatContent = new List<float>();
        public List<float> FatContent { get { return _fatContent; } }
        public int Units { get; set; }
        public string? Raw { get; set; }
        public int Capacity { get; set; }
        public bool IsFarmer { get; set; }
    }
}
