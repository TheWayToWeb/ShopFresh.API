using Items.Application.Interfaces;
using MakeCookie = Items.Domain.Models.Categories.Bakery.Cookie.MakeCookie;
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
            MakeCookie cookie = new(
                request.PersonId,
                request.ItemName,
                request.Price,
                request.ImagePath!
            );

            var actualCookie = cookie.CreateCookie();

            await _dbContext.Cookies.AddAsync(actualCookie, cancellationToken);

            await _dbContext.Cookies.AddAsync(actualCookie, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return actualCookie.ItemId;
        }
    }
}
