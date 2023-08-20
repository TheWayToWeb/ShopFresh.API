using Items.Domain.Components.Entities.Common;
using MediatR;

namespace Items.Application.Products.Drinks.Water.Commands.CreateWater
{
    public class CreateWater : IRequest<Guid>
    {
        public string? ItemName { get; set; }
        public int Price { get; set; }
        public string? ImagePath { get; set; }
        public int MinTemp { get; set; }
        public int MaxTemp { get; set; }
        public float Protein { get; set; }
        public float Sugar { get; set; }
        public float Energy { get; set; }
        public int CountInPackage { get; set; }
        public DateOnly BeforeDate { get; set; }
        public List<SoldCapacity>? Capacity { get; set; } = new();
        public List<ProductTaste>? Taste { get; set; } = new();
        public bool IsChilled { get; set; }
        public bool IsSparkling { get; set; }
        public string? Purpose { get; set; }
    }
}
