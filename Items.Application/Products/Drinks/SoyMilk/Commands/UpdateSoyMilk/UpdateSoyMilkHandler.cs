using Items.Application.Interfaces;
using Items.Domain.Products.FreshItem.Drinks.MakingSoyMilk;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Items.Application.Products.Drinks.SoyMilk.Commands.UpdateSoyMilk
{
    public class UpdateSoyMilkHandler : IRequestHandler<UpdateSoyMilk, Unit>
    {
        private readonly IDrinkDbContext _dbContext;
        private readonly MakeSoyMilk _selfSoyMilk;

        public UpdateSoyMilkHandler(IDrinkDbContext dbContext) {
            _dbContext = dbContext;
            _selfSoyMilk = new();
        }

        public async Task<Unit> Handle(UpdateSoyMilk request, CancellationToken cancellationToken)
        {
            var soyMilk = await _dbContext.SoyMilk.FirstOrDefaultAsync(item => item.ItemId == request.ItemId, cancellationToken);

            if (soyMilk is null || request.PersonId != soyMilk.PersonId) {
                throw new NotImplementedException();
            }

            _selfSoyMilk.ItemName(request.ItemName);
            _selfSoyMilk.Price(request.Price);
            _selfSoyMilk.ImagePath(request.ImagePath);
            _selfSoyMilk.Maker(request.Maker);
            _selfSoyMilk.MinTemp(request.MinTemp);
            _selfSoyMilk.MaxTemp(request.MaxTemp);
            _selfSoyMilk.Protein(request.Protein);
            _selfSoyMilk.Fat(request.Fat);
            _selfSoyMilk.Sugar(request.Sugar);
            _selfSoyMilk.Energy(request.Energy);
            _selfSoyMilk.CountInPackage(request.CountInPackage);
            _selfSoyMilk.CreatedDate(request.CreatedDate);
            _selfSoyMilk.Taste(request.Tastes);
            _selfSoyMilk.Capacity(request.Capacities);
            _selfSoyMilk.IsChilled(request.IsChilled);
            _selfSoyMilk.KindOfMilk(request.KindOfMilk);

            soyMilk.ItemName = _selfSoyMilk.itemName;
            soyMilk.Price = _selfSoyMilk.price;
            soyMilk.ImagePath = _selfSoyMilk.imagePath;
            soyMilk.Maker = _selfSoyMilk.maker;
            soyMilk.MinTemp = _selfSoyMilk.minTemp;
            soyMilk.MaxTemp = _selfSoyMilk.maxTemp;
            soyMilk.Protein = _selfSoyMilk.protein;
            soyMilk.Fat = _selfSoyMilk.fat;
            soyMilk.Sugar = _selfSoyMilk.sugar;
            soyMilk.Energy = _selfSoyMilk.energy;
            soyMilk.CountInPackage = _selfSoyMilk.countInPackage;
            soyMilk.CreatedDate = _selfSoyMilk.createdDate;
            soyMilk.Capacities = _selfSoyMilk.capacities;
            soyMilk.IsChilled = _selfSoyMilk.isChilled;
            soyMilk.KindOfMilk = _selfSoyMilk.kindOfMilk;

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
