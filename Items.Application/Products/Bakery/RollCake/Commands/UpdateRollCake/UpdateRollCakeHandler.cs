using Items.Application.Interfaces;
using Items.Domain.Components.Entities.Categories.Bakery.RollCake;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Items.Application.Products.Bakery.RollCake.Commands.UpdateRollCake
{
    public class UpdateRollCakeHandler : IRequestHandler<UpdateRollCake, Unit>
    {
        private readonly IBakeryDbContext _dbContext;
        private readonly MakeRollCake _selfRollCake;

        public UpdateRollCakeHandler(IBakeryDbContext dbContext) {
            _dbContext = dbContext;
            _selfRollCake = new();
        }

        public async Task<Unit> Handle(UpdateRollCake request, CancellationToken cancellationToken)
        {
            var rollCake = await _dbContext.RollCakes.FirstOrDefaultAsync(item => item.ItemId == request.ItemId, cancellationToken);

            if (rollCake is null || request.PersonId != rollCake.PersonId)
            {
                throw new NotImplementedException();
            }

            _selfRollCake.ItemName(request.ItemName);
            _selfRollCake.Price(request.Price);
            _selfRollCake.ImagePath(request.ImagePath);
            _selfRollCake.Maker(request.Maker);
            _selfRollCake.MinTemp(request.MinTemp);
            _selfRollCake.MaxTemp(request.MaxTemp);
            _selfRollCake.Protein(request.Protein);
            _selfRollCake.Fat(request.Fat);
            _selfRollCake.Sugar(request.Sugar);
            _selfRollCake.Energy(request.Energy);
            _selfRollCake.CountInPackage(request.CountInPackage);
            _selfRollCake.CreatedDate(request.CreatedDate);
            _selfRollCake.Weight(request.Weight);
            _selfRollCake.CoolingMode(request.CoolingMode);
            _selfRollCake.IsFarmer(request.IsFarmer);
            _selfRollCake.ProductBakeryKind(request.ProductBakeryKind);
            _selfRollCake.Addition(request.Addition);

            rollCake.ItemName =     _selfRollCake.itemName;
            rollCake.Price =        _selfRollCake.price;
            rollCake.ImagePath =    _selfRollCake.imagePath;
            rollCake.Maker =        _selfRollCake.maker;
            rollCake.MinTemp =      _selfRollCake.minTemp;
            rollCake.MaxTemp =      _selfRollCake.maxTemp;
            rollCake.Protein =      _selfRollCake.protein;
            rollCake.Fat =          _selfRollCake.fat;
            rollCake.Sugar =        _selfRollCake.sugar;
            rollCake.Energy =       _selfRollCake.energy;
            rollCake.CountInPackage = _selfRollCake.countInPackage;
            rollCake.CreatedDate =  _selfRollCake.createdDate;
            rollCake.Weight =       _selfRollCake.weight;
            rollCake.CoolingMode =  _selfRollCake.coolingMode;
            rollCake.IsFarmer =     _selfRollCake.isFarmer;
            rollCake.ProductBakeryKind = _selfRollCake.productBakeryKind;
            rollCake.Addition =     _selfRollCake.addition;

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
