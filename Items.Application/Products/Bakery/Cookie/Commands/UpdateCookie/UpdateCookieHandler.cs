using Items.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Items.Application.Products.Bakery.Cookie.Commands.UpdateCookie
{
    public class UpdateCookieHandler : IRequestHandler<UpdateCookie, Unit>
    {
        private readonly IBakeryDbContext _dbContext;

        public UpdateCookieHandler(IBakeryDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(UpdateCookie request, CancellationToken cancellationToken)
        {
            var cookie = await _dbContext.Cookies.FirstOrDefaultAsync(item => item.ItemId == request.ItemId, cancellationToken);

            if (cookie is null || request.PersonId != cookie.PersonId) {
                throw new NotImplementedException();
            }

            cookie.ItemName = request.ItemName;
            cookie.Price = request.Price;
            cookie.ImagePath = request.ImagePath;
            cookie.Maker = request.Maker;
            cookie.MinTemp = request.MinTemp;
            cookie.MaxTemp = request.Maxtemp;
            cookie.Protein = request.Protein;
            cookie.Fat = request.Fat;
            cookie.Sugar = request.Sugar;
            cookie.Energy = request.Energy;
            cookie.CountInPackage = request.CountInPackage;
            cookie.ProductExpiryDate = request.ProductExpiryDate;
            cookie.CoolingMode = request.CoolingMode;
            cookie.ProductBakeryKind = request.ProductBakeryKind;
            cookie.Addition = request.Addition;
            cookie.ProductKindItSelf = request.ProductKindItSelf;

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
