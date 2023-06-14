using MediatR;
using SelfSalad = Items.Domain.Products.FreshItem.FruitsVegetables.Vegetables.Salad;

namespace Items.Application.Products.Vegetables.SaladMix.Commands.UpdateSaladMix
{
    public class UpdateSaladMix : IRequest<Unit>
    {
        public Guid PersonId { get; set; }
        public Guid ItemId { get; set; }
        public string? ItemName { get; set; }
        public int Price { get; set; }
        public string? ImagePath { get; set; }
        public int MinTemp { get; set; }
        public int Maxtemp { get; set; }
        public float Protein { get; set; }
        public float Fat { get; set; }
        public float Sugar { get; set; }
        public float Energy { get; set; }
        public int CountInPackage { get; set; }
        public int ProductExpiryDate { get; set; }
        public string? CoolingMode { get; set; }
        public bool IsSlicingShape { get; set; }
        public List<SelfSalad> GreeneryKinds { get; set; } = new();
    }
}
