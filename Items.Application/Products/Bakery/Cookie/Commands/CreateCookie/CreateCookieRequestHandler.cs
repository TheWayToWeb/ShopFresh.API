using Items.Application.Interfaces;
using RealCookie = Items.Domain.Products.FreshItem.Bakery.FactoryCookie.Cookie;
using MakeCookie = Items.Domain.Products.FreshItem.Bakery.FactoryCookie.MakeCookie;
using MediatR;

namespace Items.Application.Products.Bakery.Cookie.Commands.CreateCookie
{
    public class CreateCookieRequestHandler : IRequestHandler<CreateCookieRequest, Guid>
    {
        private readonly IBakeryDbContext _dbContext;

        public CreateCookieRequestHandler(IBakeryDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateCookieRequest request, CancellationToken cancellationToken)
        {

            MakeCookie makeCookie = new(
                request.PersonId,
                Guid.NewGuid(),
                request.ItemName,
                request.Price,
                request.ImagePath,
                null,
                request.MinTemp,
                request.MaxTemp,
                request.Protein,
                request.Fat,
                request.Sugar,
                request.Energy,
                request.CountInPackage,
                request.ProductExpiryDate,
                null,
                request.CoolingMode,
                false,
                request.ProductBakeryKind,
                request.Addition,
                request.ProductKindItSelf
                );

            var cookie = makeCookie.Create();

            await _dbContext.Cookies.AddAsync((RealCookie)cookie, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return cookie.ItemId;
        }
    }
}
