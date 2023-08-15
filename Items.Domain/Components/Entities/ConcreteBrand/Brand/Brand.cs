using Items.Domain.Components.Entities;

namespace Items.Domain.Components.Entities.ConcreteBrand.Brand
{
    public class Brand
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public List<Item>? Items { get; set; }
    }
}
