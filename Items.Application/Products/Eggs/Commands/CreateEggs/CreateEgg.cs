using Items.Domain.Brands;
using Items.Domain.Enums;
using MediatR;

namespace Items.Application.Products.Eggs.Commands.CreateEggs
{
    public class CreateEgg : IRequest<Guid>
    {
        public string? ItemName { get; set; }
        public int Price { get; set; }
        public string? ImagePath { get; set; }
        public int MinTemp { get; set; }
        public int Maxtemp { get; set; }
        public string? Shape { get; set; }
        public float Weight { get; set; }
        public float Protein { get; set; }
        public float Fat { get; set; }
        public float Sugar { get; set; }
        public float Energy { get; set; }
        public int CountInPackage { get; set; }
        public DateOnly BeforeDate { get; set; }
        public string? Kind { get; set; }
        public Category Sort { get; set; }
        public bool IsFarmer { get; set; }
    }
}
