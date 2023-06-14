using Items.Domain.Products.FreshItem.FruitsVegetables.Vegetables;
using MediatR;

namespace Items.Application.Products.SaladMix.Commands.CreateSaladMix
{
    public class CreateSaladMix : IRequest<Guid>
    {
        public Guid PersonId { get; set; }
        public string? ItemName { get; set; }
        public int Price { get; set; }
        public string? ImagePath { get; set; }
        public int MinTemp { get; set; }
        public int Maxtemp { get; set; }
        public float Protein { get; set; }
        public float Energy { get; set; }
        public int CountInPackage { get; set; }
        public int ProductExpiryDate { get; set; }
        public string? CoolingMode { get; set; }
        public bool IsSlicingShape { get; set; }
        public List<Salad> GreeneryKinds { get; set; } = new();
    }
}
