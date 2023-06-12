using Items.Application.Interfaces;
using SelfCookie = Items.Domain.Products.FreshItem.Bakery.Cookie;
using MediatR;

namespace Items.Application.Products.Bakery.Cookie.Commands.CreateCookie
{
    public class CreateCookieHandler : IRequestHandler<CreateCookie, Guid>
    {
        private readonly IBakeryDbContext _dbContext;

        public CreateCookieHandler(IBakeryDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateCookie request, CancellationToken cancellationToken)
        {
            var cookie = new SelfCookie
            {
                PersonId = Guid.NewGuid(),
                ItemId = Guid.NewGuid(),
                ItemName = request.ItemName,
                BrandId = Guid.NewGuid(),
                Price = request.Price,
                ImagePath = request.ImagePath,
                MinTemp = request.MinTemp,
                MaxTemp = request.MaxTemp,
                Protein = request.Protein,
                Fat = request.Fat,
                Sugar = request.Sugar,
                Energy = request.Energy,
                BeforeDate = request.BeforeDate,
                ProductBakeryKind = request.ProductBakeryKind,
                CoolingMode = request.CoolingMode,
                ProductKindItSelf = request.ProductKindItSelf
            };

            await _dbContext.Cookies.AddAsync(cookie, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return cookie.ItemId;
        }
    }
}
