using Items.Application.Interfaces;
using Items.Domain.Components.Entities.Categories.Drinks.ConcreteJuice.Juice.Juice;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Items.Application.Products.Drinks.Juice.Commands.UpdateJuice
{
    public class UpdateJuiceHandler : IRequestHandler<UpdateJuice, Unit>
    {
        private readonly IDrinkDbContext _dbContext;
        private readonly MakeJuice _selfJuice;

        public UpdateJuiceHandler(IDrinkDbContext dbContext) {
            _dbContext = dbContext;
            _selfJuice = new();
        }
        public async Task<Unit> Handle(UpdateJuice request, CancellationToken cancellationToken)
        {
            var juice = await _dbContext.Juices.FirstOrDefaultAsync(item => item.ItemId == request.ItemId, cancellationToken);

            if (juice is null || request.PersonId != juice.PersonId)
            {
                throw new NotImplementedException();
            }

            _selfJuice.ItemName(request.ItemName);
            _selfJuice.Price(request.Price);
            _selfJuice.ImagePath(request.ImagePath);
            _selfJuice.Maker(request.Maker);
            _selfJuice.MinTemp(request.MinTemp);
            _selfJuice.MaxTemp(request.MaxTemp);
            _selfJuice.Protein(request.Protein);
            _selfJuice.Fat(request.Fat);
            _selfJuice.Sugar(request.Sugar);
            _selfJuice.Energy(request.Energy);
            _selfJuice.CountInPackage(request.CountInPackage);
            _selfJuice.CreatedDate(request.CreatedDate);
            _selfJuice.Taste(request.Tastes);
            _selfJuice.Capacity(request.Capacities);
            _selfJuice.IsChilled(request.IsChilled);

            juice.ItemName =    _selfJuice.itemName;
            juice.Price =       _selfJuice.price;
            juice.ImagePath =   _selfJuice.imagePath;
            juice.Maker =       _selfJuice.maker;
            juice.MinTemp =     _selfJuice.minTemp;
            juice.MaxTemp =     _selfJuice.maxTemp;
            juice.Protein =     _selfJuice.protein;
            juice.Fat =         _selfJuice.fat;
            juice.Sugar =       _selfJuice.sugar;
            juice.Energy =      _selfJuice.energy;
            juice.CountInPackage = _selfJuice.countInPackage;
            juice.CreatedDate = _selfJuice.createdDate;
            juice.Tastes =      _selfJuice.tastes;
            juice.Capacities =  _selfJuice.capacities;
            juice.IsChilled =   _selfJuice.isChilled;

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
