using Items.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Items.Application.Products.Bakery.Gingerbread.Commands.UpdateGingerbread
{
    public class UpdateGingerbreadHandler : IRequestHandler<UpdateGingerbread, Unit>
    {
        private readonly IBakeryDbContext _dbContext;

        public UpdateGingerbreadHandler(IBakeryDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(UpdateGingerbread request, CancellationToken cancellationToken)
        {
            var gingerbread = await _dbContext.Gingerbreads.FirstOrDefaultAsync(item => item.ItemId == request.ItemId, cancellationToken);

            if (gingerbread is null || request.PersonId != gingerbread.PersonId) {
                throw new NotImplementedException();
            }

            gingerbread.ItemName = request.ItemName;
            gingerbread.Price = request.Price;
            gingerbread.ImagePath = request.ImagePath;
            gingerbread.Maker = request.Maker;
            gingerbread.MinTemp = request.MinTemp;
            gingerbread.MaxTemp = request.MaxTemp;
            gingerbread.Protein = request.Protein;
            gingerbread.Fat = request.Fat;
            gingerbread.Sugar = request.Sugar;
            gingerbread.Energy = request.Energy;
            gingerbread.CountInPackage = request.CountInPackage;
            gingerbread.ProductExpiryDate = request.ProductExpiryDate;
            gingerbread.Weight = request.Weight;
            gingerbread.ProductBakeryKind = request.ProductBakeryKind;
            gingerbread.ProductKindItSelf = request.ProductKindItSelf;

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
