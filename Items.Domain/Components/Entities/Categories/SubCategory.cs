using Items.Domain.Components.Entities.Categories.Common;

namespace Items.Domain.Components.Entities.Categories
{
    public class SubCategory
    {
        public Guid SubCategoryId { get; private set; }
        public Guid CategoryId { get; private set; }
        public string? SubCategoryName { get; private set; }
        public Category? Category { get; set; }
        public List<Item> Items { get; private set; } = new();
    }
}
