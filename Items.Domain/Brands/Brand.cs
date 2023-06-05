using Items.Domain.Products.FreshItem;

namespace Items.Domain.Brands
{
    public class Brand
    {
        public Guid Id { get; set; }
        public string? BrandName { get; set; }
        public List<Item> Items { get; set; } = new();
    }
}
