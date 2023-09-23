using Items.Domain.Components.Items;

namespace Items.Domain.Components.Categories
{
    public class SubCategory
    {
        public Guid Id { get; private set; }
        public string? SubCategoryName { get; private set; }
        public List<Item> Items { get; private set; } = new();
        public Guid CategoryId { get; private set; }
        public Category? Category { get; set; }
    }
}
