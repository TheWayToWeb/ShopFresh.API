using MediatR;

namespace Items.Application.Products.FruisVegetables.Vegetables.Cabbage.Commands.CreateCabbage
{
    public class CreateCabbage : IRequest<Guid>
    {
        public string? ItemName { get; set; }
        public int Price { get; set; }
        public string? ImagePath { get; set; }
        public int MinTemp { get; set; }
        public int MaxTemp { get; set; }
        public float Protein { get; set; }
        public float Fat { get; set; }
        public float Sugar { get; set; }
        public float Energy { get; set; }
        public int CountInPackage { get; set; }
        public DateOnly BeforeDate { get; set; }
        public float? Weight { get; set; }
        public string? ShortName { get; set; }
    }
}
