using Items.Application.Interfaces;
using MediatR;

namespace Items.Application.Products.Bakery.Gingerbread.Commands.DeleteGingerbread
{
    public class DeleteGingerBreadHandler : IRequestHandler<DeleteGingerBread, Unit>
    {
        private readonly IBakeryDbContext _dbContext;

        public DeleteGingerBreadHandler(IBakeryDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(DeleteGingerBread request, CancellationToken cancellationToken)
        {
            var gingerBread = await _dbContext.Gingerbreads.FindAsync(new object[] { request.ItemId }, cancellationToken);

            if (gingerBread is null || request.PersonId != gingerBread.PersonId) {
                throw new NotImplementedException();
            }

            _dbContext.Gingerbreads.Remove(gingerBread);

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
