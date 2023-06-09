using SelfCategory = Items.Domain.Categories.Category.Category;

namespace Items.Domain.Categories.SubCategory
{
    public class SubCategory
    {
        public Guid Id { get; set; }
        public string? SubCategoryName { get; set; }
        public List<SubCategory>? FreshGroups { get; set; } = new List<SubCategory>();
        public Guid CategoryId { get; set; }
        public SelfCategory? Category { get; set; }
    }
}
