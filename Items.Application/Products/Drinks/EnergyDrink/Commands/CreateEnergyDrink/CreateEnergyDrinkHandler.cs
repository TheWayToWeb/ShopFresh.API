using Items.Application.Interfaces;
using MediatR;
using Items.Domain.Models.Categories.Drinks.EnergyDrink;

namespace Items.Application.Products.Drinks.EnergyDrink.Commands.CreateEnergyDrink
{
    public class CreateEnergyDrinkHandler : IRequestHandler<CreateEnergyDrink, Guid>
    {
        private readonly IDrinkDbContext _dbContext;
        private MakeEnergyDrink _selfEnergyDrink;

        public CreateEnergyDrinkHandler(IDrinkDbContext dbContext, MakeEnergyDrink selfEnergyDrink) {
            _dbContext = dbContext;
            _selfEnergyDrink = selfEnergyDrink;
        }

        public async Task<Guid> Handle(CreateEnergyDrink request, CancellationToken cancellationToken)
        {
            _selfEnergyDrink = new(
                request.PersonId,
                request.ItemName,
                request.Price,
                request.ImagePath
            );

            var energyDrink = _selfEnergyDrink.CreateEnergyDrink();

            await _dbContext.EnergyDrinks.AddAsync(energyDrink, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return energyDrink.ItemId;
        }
    }
}
