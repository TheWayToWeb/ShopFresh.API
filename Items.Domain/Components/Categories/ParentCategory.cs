namespace Items.Domain.Components.Categories
{
    public class ParentCategory
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}
