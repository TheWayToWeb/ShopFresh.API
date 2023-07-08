using Items.Application.Interfaces;
using Items.Domain.Products.FreshItem.Drinks.MakingEnergyDrink;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Items.Application.Products.Drinks.EnergyDrink.Commands.UpdateEnergyDrink
{
    public class UpdateEnergyDrinkHandler : IRequestHandler<UpdateEnergyDrink, Unit>
    {
        private readonly IDrinkDbContext _dbContext;
        private readonly MakeEnergyDrink _selfEnergyDrink;

        public UpdateEnergyDrinkHandler(IDrinkDbContext dbContext) {
            _dbContext = dbContext;
            _selfEnergyDrink = new();
        }

        public async Task<Unit> Handle(UpdateEnergyDrink request, CancellationToken cancellationToken)
        {
            var energyDrink = await _dbContext.EnergyDrinks.FirstOrDefaultAsync(item => item.ItemId == request.ItemId, cancellationToken);

            if (energyDrink is null || request.PersonId != energyDrink.PersonId) {
                throw new NotImplementedException();
            }

            _selfEnergyDrink.ItemName(request.ItemName);
            _selfEnergyDrink.Price(request.Price);
            _selfEnergyDrink.ImagePath(request.ImagePath);
            _selfEnergyDrink.Maker(request.Maker);
            _selfEnergyDrink.MinTemp(request.MinTemp);
            _selfEnergyDrink.MaxTemp(request.MaxTemp);
            _selfEnergyDrink.Protein(request.Protein);
            _selfEnergyDrink.Fat(request.Fat);
            _selfEnergyDrink.Sugar(request.Sugar);
            _selfEnergyDrink.Energy(request.Energy);
            _selfEnergyDrink.CountInPackage(request.CountInPackage);
            _selfEnergyDrink.CreatedDate(request.CreatedDate);
            _selfEnergyDrink.Taste(request.Tastes);
            _selfEnergyDrink.Capacity(request.Capacities);
            _selfEnergyDrink.IsChilled(request.IsChilled);
            _selfEnergyDrink.SaleStatus(request.Sales);
            _selfEnergyDrink.Coffein(request.Coffein);

            energyDrink.ItemName =  _selfEnergyDrink.itemName;
            energyDrink.Price =     _selfEnergyDrink.price;
            energyDrink.ImagePath = _selfEnergyDrink.imagePath;
            energyDrink.Maker =     _selfEnergyDrink.maker;
            energyDrink.MinTemp =   _selfEnergyDrink.minTemp;
            energyDrink.MaxTemp =   _selfEnergyDrink.maxTemp;
            energyDrink.Protein =   _selfEnergyDrink.protein;
            energyDrink.Fat =       _selfEnergyDrink.fat;
            energyDrink.Sugar =     _selfEnergyDrink.sugar;
            energyDrink.Energy =    _selfEnergyDrink.energy;
            energyDrink.CountInPackage = _selfEnergyDrink.countInPackage;
            energyDrink.CreatedDate = _selfEnergyDrink.createdDate;
            energyDrink.Tastes =    _selfEnergyDrink.tastes;
            energyDrink.Capacities = _selfEnergyDrink.capacities;
            energyDrink.IsChilled = _selfEnergyDrink.isChilled;
            energyDrink.Sales =     _selfEnergyDrink.sales;
            energyDrink.Coffein =   _selfEnergyDrink.coffein;

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
