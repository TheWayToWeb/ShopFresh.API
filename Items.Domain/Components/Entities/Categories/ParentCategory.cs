namespace Items.Domain.Components.Entities.Categories
{
    public class ParentCategory
    {
        public Guid Id { get; private set; }
        public string? Name { get; private set; }
        public List<Category> Category { get; private set; } = new();
    }
}
