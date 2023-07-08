using MediatR;

namespace Items.Application.Products.Drinks.EnergyDrink.Commands.CreateEnergyDrink
{
    public class CreateEnergyDrink : IRequest<Guid>
    {
        public Guid PersonId { get; set; }
        public string ItemName { get; set; } = "";
        public int Price { get; set; }
        public string ImagePath { get; set; } = "";
    }
}
