using MediatR;

namespace Items.Application.Products.Drinks.EnergyDrink.Commands.DeleteEnergyDrink
{
    public class DeleteEnergyDrink : IRequest<Unit>
    {
        public Guid PersonId { get; set; }
        public Guid ItemId { get; set; }
    }
}
