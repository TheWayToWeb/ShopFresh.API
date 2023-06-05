namespace Items.Domain.Categories.Category
{
    public class Category
    {
        public Guid CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public List<Category>? SubCategory { get; set; } = new List<Category>();

    }
}
