using Items.Domain.Products.Template;
using MediatR;

namespace Items.Application.Products.Drinks.Coffee.Commands.CreateCoffee
{
    public class CreateCoffee : IRequest<Guid>
    {
        public string? ItemName { get; set; }
        public int Price { get; set; }
        public string? ImagePath { get; set; }
        public int MinTemp { get; set; }
        public int MaxTemp { get; set; }
        public float Weight { get; set; }
        public float Protein { get; set; }
        public float Fat { get; set; }
        public float Sugar { get; set; }
        public float Energy { get; set; }
        public int CountInPackage { get; set; }
        public DateOnly BeforeDate { get; set; }
        public string? TypeOfCoffee { get; set; }
        public string? KindOfCoffee { get; set; }
        public string? Consistency { get; set; }
        public string? Composition { get; set; }
        public string? TasteIntensity { get; set; }
        public bool IsCoffeinFree { get; set; }

    }
}
