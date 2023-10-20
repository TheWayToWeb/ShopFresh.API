using Items.Domain.Components.Entities.Common;

namespace Items.Domain.Components.Items
{
    public abstract class Item
    {
        public Guid Id { get; set; }
        public Guid BrandId { get; set; }
        public Brand Brand { get; set; }
        public int Price { get; set; }
        public string ImagePath { get; set; }
        public string Maker { get; set; }
        public int CountInPackage { get; set; }
        public float Weight { get; set; }
        public string Description { get; set; }
}