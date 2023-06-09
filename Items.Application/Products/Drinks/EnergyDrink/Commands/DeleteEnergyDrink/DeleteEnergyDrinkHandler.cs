using Items.Application.Interfaces;
using MediatR;

namespace Items.Application.Products.Drinks.EnergyDrink.Commands.DeleteEnergyDrink
{
    public class DeleteEnergyDrinkHandler : IRequestHandler<DeleteEnergyDrink, Unit>
    {
        private readonly IDrinkDbContext _dbContext;

        public DeleteEnergyDrinkHandler(IDrinkDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(DeleteEnergyDrink request, CancellationToken cancellationToken)
        {
            var energyDrink = await _dbContext.EnergyDrinks.FindAsync(new object[] { request.ItemId },cancellationToken);

            if (energyDrink is null || request.PersonId != energyDrink.PersonId) {
                throw new NotImplementedException();
            }

            _dbContext.EnergyDrinks.Remove(energyDrink);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
