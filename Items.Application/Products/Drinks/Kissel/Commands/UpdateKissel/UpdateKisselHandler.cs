using Items.Application.Interfaces;
using Items.Domain.Components.Entities.Categories.Drinks.ConcreteKissel.Kissel.Kissel;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Items.Application.Products.Drinks.Kissel.Commands.UpdateKissel
{
    public class UpdateKisselHandler : IRequestHandler<UpdateKissel, Unit>
    {
        private readonly IDrinkDbContext _dbContext;
        private readonly MakeKissel _selfKissel;

        public UpdateKisselHandler(IDrinkDbContext dbContext) {
            _dbContext = dbContext;
            _selfKissel = new();
        }

        public async Task<Unit> Handle(UpdateKissel request, CancellationToken cancellationToken)
        {
            var kissel = await _dbContext.Kissel.FirstOrDefaultAsync(item => item.ItemId == request.ItemId, cancellationToken);

            if (kissel is null || request.PersonId != kissel.PersonId)
            {
                throw new NotImplementedException();
            }

            _selfKissel.ItemName(request.ItemName);
            _selfKissel.Price(request.Price);
            _selfKissel.ImagePath(request.ImagePath);
            _selfKissel.Maker(request.Maker);
            _selfKissel.MinTemp(request.MinTemp);
            _selfKissel.MaxTemp(request.MaxTemp);
            _selfKissel.Protein(request.Protein);
            _selfKissel.Fat(request.Fat);
            _selfKissel.Sugar(request.Sugar);
            _selfKissel.Energy(request.Energy);
            _selfKissel.CountInPackage(request.CountInPackage);
            _selfKissel.CreatedDate(request.CreatedDate);
            _selfKissel.Taste(request.Tastes);
            _selfKissel.Capacity(request.Capacities);
            _selfKissel.IsChilled(request.IsChilled);

            kissel.ItemName =   _selfKissel.itemName;
            kissel.Price =      _selfKissel.price;
            kissel.ImagePath =  _selfKissel.imagePath;
            kissel.Maker =      _selfKissel.maker;
            kissel.MinTemp =    _selfKissel.minTemp;
            kissel.MaxTemp =    _selfKissel.maxTemp;
            kissel.Protein =    _selfKissel.protein;
            kissel.Fat =        _selfKissel.fat;
            kissel.Sugar =      _selfKissel.sugar;
            kissel.Energy =     _selfKissel.energy;
            kissel.CountInPackage = _selfKissel.countInPackage;
            kissel.CreatedDate = _selfKissel.createdDate;
            kissel.Tastes =     _selfKissel.tastes;
            kissel.Capacities = _selfKissel.capacities;
            kissel.IsChilled =  _selfKissel.isChilled;

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
