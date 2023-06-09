using SelfSubCategory = Items.Domain.Categories.SubCategory.SubCategory;

namespace Items.Domain.Categories.FreshGroup
{
    public class FreshGroup
    {
        public Guid FreshGroupId { get; set; }
        public string? FreshGroupName { get; set; }
        public List<FreshGroup>? FreshItems { get; set; } = new List<FreshGroup>();
        public Guid SubCategoryId { get; set; }
        public SelfSubCategory? SubCategory { get; set; }
    }
}
