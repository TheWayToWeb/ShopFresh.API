namespace Items.Domain.Components.Entities.Categories
{
    public class ParentCategory
    {
        public Guid ParentCategoryId { get; private set; }
        public string? ParentCategoryName { get; private set; }
        public List<Category> Category { get; private set; } = new();
    }
}
