using Items.Domain.Components.Entities.ConcreteBrand.Brand;

namespace Items.Domain.Components.Entities
{
    public abstract class Item
    {
        public Guid PersonId { get; set; }
        public Guid ItemId { get; set; }
        public int Price { get; set; }
        public string? ImagePath { get; set; }
        public string? Maker { get; set; }
        public int MinTemp { get; set; }
        public int MaxTemp { get; set; }
        public float Protein { get; set; }
        public float Fat { get; set; }
        public float Sugar { get; set; }
        public float Energy { get; set; }
        public int CountInPackage { get; set; }
        public int CreatedDate { get; set; }

        public Guid BrandId { get; set; }
        public Brand? Brand { get; set; }
    }
}