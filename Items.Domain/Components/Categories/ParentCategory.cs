namespace Items.Domain.Components.Categories
{
    public class ParentCategory
    {
        public Guid Id { get; private set; }
        public string? Name { get; private set; }
        public List<Category> Categories { get; private set; } = new();
    }
}
