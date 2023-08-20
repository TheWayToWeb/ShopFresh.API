using Items.Domain.Components.Entities.Vegetables;
using Items.Domain.Components.Entities.Vegetables.Vegetable;
using MediatR;

namespace Items.Application.Products.Vegetables.VegetableMix.CreateVegetableMix
{
    public class CreateVegetableMix : IRequest<Guid>
    {
        public Guid PersonId { get; set; }
        public string? ItemName { get; set; }
        public int Price { get; set; }
        public string? ImagePath { get; set; }
        public int MinTemp { get; set; }
        public int MaxTemp { get; set; }
        public float Protein { get; set; }
        public float Fat { get; set; }
        public float Energy { get; set; }
        public int CountInPackage { get; set; }
        public int ProductExpiryDate { get; set; }
        public float? Weight { get; set; }
        public string? CoolingMode { get; set; }
        public List<Vegetable> Vegetables { get; set; } = new();
    }
}
