namespace Items.Domain.Components.Categories
{
    public class Category
    {
        public Guid CategoryId { get; private set; }
        public string? CategoryName { get; private set; }
        public List<SubCategory> SubCategories { get; private set; } = new();
        public Guid ParentCategoryId { get; private set; }
        public ParentCategory? ParentCategory { get; set; }
    }
}
