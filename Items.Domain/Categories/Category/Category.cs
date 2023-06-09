using SelfParentCategory = Items.Domain.Categories.ParentCategory.ParentCategory;

namespace Items.Domain.Categories.Category
{
    public class Category
    {
        public Guid Id { get; set; }
        public string? CategoryName { get; set; }
        public List<Category>? SubCategories { get; set; } = new List<Category>();
        public Guid ParentCategoryId { get; set; }
        public SelfParentCategory? ParentCategory { get; set; }

    }
}
