namespace Items.Domain.Categories.SubCategory
{
    public class SubCategory
    {
        public Guid SubCategoryId { get; set; }
        public string? SubCategoryName { get; set; }
        public List<SubCategory>? FreshGroup { get; set; } = new List<SubCategory>();
    }
}
