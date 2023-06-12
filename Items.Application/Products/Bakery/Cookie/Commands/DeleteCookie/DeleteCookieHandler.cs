using Items.Application.Interfaces;
using MediatR;

namespace Items.Application.Products.Bakery.Cookie.Commands.DeleteCookie
{
    public class DeleteCookieHandler : IRequestHandler<DeleteCookie, Unit>
    {
        private readonly IBakeryDbContext _dbContext;

        public DeleteCookieHandler(IBakeryDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(DeleteCookie request, CancellationToken cancellationToken)
        {
            var cookie = await _dbContext.Cookies.FindAsync(new object[] { request.ItemId }, cancellationToken);

            if (cookie is null || request.PersonId != cookie.PersonId) {
                throw new NotImplementedException();
            }

            _dbContext.Cookies.Remove(cookie);

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
