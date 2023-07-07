using Items.Application.Interfaces;
using Items.Domain.Products.FreshItem.Drinks.MakingCoffee;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Items.Application.Products.Drinks.Coffee.Commands.UpdateCoffee
{
    public class UpdateCoffeeHandler : IRequestHandler<UpdateCoffee, Unit>
    {
        private readonly IDrinkDbContext _dbContext;
        private readonly CoffeeMake _selfCoffee;

        public UpdateCoffeeHandler(IDrinkDbContext dbContext) {
            _dbContext = dbContext;
            _selfCoffee = new();
        }

        public async Task<Unit> Handle(UpdateCoffee request, CancellationToken cancellationToken)
        {
            var coffee = await _dbContext.Coffee.FirstOrDefaultAsync(item => item.ItemId == request.ItemId, cancellationToken);

            if (coffee is null || request.PersonId != coffee.PersonId) {
                throw new NotImplementedException();
            }


            _selfCoffee.ItemName(request.ItemName);
            _selfCoffee.Price(request.Price);
            _selfCoffee.ImagePath(request.ImagePath);
            _selfCoffee.Maker(request.Maker);
            _selfCoffee.MinTemp(request.MinTemp);
            _selfCoffee.MaxTemp(request.MaxTemp);
            _selfCoffee.Protein(request.Protein);
            _selfCoffee.Fat(request.Fat);
            _selfCoffee.Sugar(request.Sugar);
            _selfCoffee.Energy(request.Energy);
            _selfCoffee.CountInPackage(request.CountInPackage);
            _selfCoffee.CreatedDate(request.CreatedDate);
            _selfCoffee.Taste(request.Tastes);
            _selfCoffee.Capacity(request.Capacities);
            _selfCoffee.IsChilled(request.IsChilled);
            _selfCoffee.TypeCoffee(request.TypeCoffee);
            _selfCoffee.KindOfCoffee(request.KindOfCoffee);
            _selfCoffee.Consistency(request.Consistency);
            _selfCoffee.Composition(request.Composition);
            _selfCoffee.TasteIntensity(request.TasteIntensity);
            _selfCoffee.IsCoffeinFree(request.IsCoffeinFree);

            coffee.ItemName =   _selfCoffee.itemName;
            coffee.Price =      _selfCoffee.price;
            coffee.ImagePath =  _selfCoffee.imagePath;
            coffee.Maker =      _selfCoffee.maker;
            coffee.MinTemp =    _selfCoffee.minTemp;
            coffee.MaxTemp =    _selfCoffee.maxTemp;
            coffee.Protein =    _selfCoffee.protein;
            coffee.Fat =        _selfCoffee.fat;
            coffee.Sugar =      _selfCoffee.sugar;
            coffee.Energy =     _selfCoffee.energy;
            coffee.CountInPackage = _selfCoffee.countInPackage;
            coffee.CreatedDate = _selfCoffee.createdDate;
            coffee.Tastes =     _selfCoffee.tastes;
            coffee.Capacities = _selfCoffee.capacities;
            coffee.IsChilled =  _selfCoffee.isChilled;
            coffee.TypeCoffee = _selfCoffee.typeCoffee;
            coffee.KindOfCofee = _selfCoffee.kindOfCoffee;
            coffee.Consistency = _selfCoffee.consistency;
            coffee.Composition = _selfCoffee.composition;
            coffee.TasteIntensity = _selfCoffee.tasteIntensity;
            coffee.IsCoffeinFree = _selfCoffee.isCoffeinFree;

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
