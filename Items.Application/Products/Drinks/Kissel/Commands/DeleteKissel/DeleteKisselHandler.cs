using Items.Application.Interfaces;
using MediatR;

namespace Items.Application.Products.Drinks.Kissel.Commands.DeleteKissel
{
    public class DeleteKisselHandler : IRequestHandler<DeleteKissel, Unit>
    {
        private readonly IDrinkDbContext _dbContext;

        public DeleteKisselHandler(IDrinkDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(DeleteKissel request, CancellationToken cancellationToken)
        {
            var kissel = await _dbContext.Kissel.FindAsync(new object[] { request.ItemId }, cancellationToken);

            if (kissel is null || request.PersonId != kissel.PersonId)
            {
                throw new NotImplementedException();
            }

            _dbContext.Kissel.Remove(kissel);

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
