namespace Items.Domain.Components.Entities.Categories.Common
{
    public class Brand
    {
        public Guid Id { get; private set; }
        public string? BrandName { get; private set; }
        public List<Item>? Items { get; set; }
    }
}
