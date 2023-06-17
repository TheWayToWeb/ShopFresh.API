using Items.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Items.Application.Products.Bakery.FancyCake.Commands.UpdateFancyCookie
{
    public class UpdateFancyCakeHandler : IRequestHandler<UpdateFancyCake, Unit>
    {
        private readonly IBakeryDbContext _dbContext;

        public UpdateFancyCakeHandler(IBakeryDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(UpdateFancyCake request, CancellationToken cancellationToken)
        {
            var fancyCake = await _dbContext.FancyCakes.FirstOrDefaultAsync(item => item.ItemId == request.ItemId, cancellationToken);

            if (fancyCake is null || request.PersonId != fancyCake.PersonId) {
                throw new NotImplementedException();
            }

            fancyCake.ItemName = request.ItemName;
            fancyCake.Price = request.Price;
            fancyCake.ImagePath = request.ImagePath;
            fancyCake.Maker = request.Maker;
            fancyCake.MinTemp = request.MinTemp;
            fancyCake.MaxTemp = request.MaxTemp;
            fancyCake.Protein = request.Protein;
            fancyCake.Fat = request.Fat;
            fancyCake.Sugar = request.Sugar;
            fancyCake.Energy = request.Energy;
            fancyCake.CountInPackage = request.CountInPackage;
            fancyCake.ProductExpiryDate = request.ProductExpiryDate;
            fancyCake.ProductBakeryKind = request.ProductBakeryKind;
            fancyCake.Weight = request.Weight;
            fancyCake.CoolingMode = request.CoolingMode;
            fancyCake.ProductKindItSelf = request.ProductKindItSelf;
            fancyCake.ProductTypeItSelf = request.ProductTypeItSelf;

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
