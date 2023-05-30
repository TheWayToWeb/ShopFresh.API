namespace Items.Domain.Products
{
    public class ParentCategory
    {
        public Guid TitleId { get; set; }
        public string? Title { get; set; }
        public List<ParentCategory>? Category { get; set; } = new List<ParentCategory>();

    }
}
