namespace Items.Domain.Components.Entities.Categories
{
    public class Category
    {
        public Guid CategoryId { get; private set; }
        public string? CategoryName { get; private set; }
        public List<Category> SubCategories { get; private set; } = new();
        public Guid ParentCategoryId { get; private set; }
        public Category? ParentCategory { get; set; }
    }
}
