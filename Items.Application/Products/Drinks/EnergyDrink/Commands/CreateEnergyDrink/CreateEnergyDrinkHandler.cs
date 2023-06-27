using Items.Application.Interfaces;
using SelfEnergyDrink = Items.Domain.Products.FreshItem.Drinks.MakingEnergyDrink.EnergyDrink;
using MediatR;

namespace Items.Application.Products.Drinks.EnergyDrink.Commands.CreateEnergyDrink
{
    public class CreateEnergyDrinkHandler : IRequestHandler<CreateEnergyDrink, Guid>
    {
        private readonly IDrinkDbContext _dbContext;

        public CreateEnergyDrinkHandler(IDrinkDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateEnergyDrink request, CancellationToken cancellationToken)
        {
            var energyDrink = new SelfEnergyDrink
            {
                PersonId = Guid.NewGuid(),
                ItemId = Guid.NewGuid(),
                ItemName = request.ItemName,
                BrandId = Guid.NewGuid(),
                Price = request.Price,
                ImagePath = request.ImagePath,
                MinTemp = request.MinTemp,
                MaxTemp = request.MaxTemp,
                Protein = request.Protein,
                Fat = request.Fat,
                Sugar = request.Sugar,
                Energy = request.Energy,
                CountInPackage = request.CountInPackage,
                BeforeDate = request.BeforeDate,
                Capacity = request.Capacity,
                Taste = request.Taste,
                IsChilled = request.IsChilled,
                State = request.State,
                Coffein = request.Coffein
            };

            await _dbContext.EnergyDrinks.AddAsync(energyDrink, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return energyDrink.ItemId;
        }
    }
}
