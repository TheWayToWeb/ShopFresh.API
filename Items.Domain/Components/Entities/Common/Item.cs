namespace Items.Domain.Components.Entities.Common
{
    public abstract class Item
    {
        public Guid PersonId { get; private set; }
        public Guid ItemId { get; private set; }
        public int Price { get; private set; }
        public string? ImagePath { get; private set; }
        public string? Maker { get; private set; }
        public int CountInPackage { get; private set; }
        public float Weight { get; private set; }
        public Guid BrandId { get; private set; }
        public Brand? Brand { get; set; }
        public string? Description { get; private set; }
    }
}