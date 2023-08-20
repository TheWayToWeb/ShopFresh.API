using Items.Domain.Components.Person;

namespace Items.Domain.Components.Entities.Common
{
    public abstract class Item
    {
        public Guid Id { get; set; }
        public Guid BrandId { get; set; }
        public Brand? Brand { get; set; }
        public int Price { get; private set; }
        public string? ImagePath { get; private set; }
        public string? Maker { get; private set; }
        public int CountInPackage { get; private set; }
        public float Weight { get; private set; }
        public string? Description { get; private set; }
        public Guid UserId { get; private set; }
        public User? User { get; set; }
    }
}