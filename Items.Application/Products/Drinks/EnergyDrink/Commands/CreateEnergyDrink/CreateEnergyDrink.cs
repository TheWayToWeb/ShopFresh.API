using Items.Domain.Products.Template;
using Items.Domain.Products.Templates;
using MediatR;

namespace Items.Application.Products.Drinks.EnergyDrink.Commands.CreateEnergyDrink
{
    public class CreateEnergyDrink : IRequest<Guid>
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
        public List<Capacity> Capacity { get; set; } = new();
        public List<Taste>? Taste { get; set; } = new();
        public bool IsChilled { get; set; }
        public List<State>? State { get; set; } = new();
        public float Coffein { get; set; }
    }
}
