namespace Items.Domain.Components.Entities.Categories.Common
{
    public class Brand
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public List<Item>? Items { get; set; }
    }
}
