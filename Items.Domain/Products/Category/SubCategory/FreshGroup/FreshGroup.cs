namespace Items.Domain.Products.Category.SubCategory.FreshGroup
{
    public class FreshGroup
    {
        public Guid FreshGroupId { get; set; }
        public string? FreshGroupName { get; set; }
        public List<FreshGroup>? FreshItem { get; set; } = new List<FreshGroup>();
    }
}
