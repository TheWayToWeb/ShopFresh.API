using Items.Application.Interfaces;
using MediatR;

namespace Items.Application.Products.Vegetables.Beet.Commands.DeleteBeet
{
    public class DeleteBeetHandler : IRequestHandler<DeleteBeet, Unit>
    {
        private readonly IVegetableDbContext _dbContext;

        public DeleteBeetHandler(IVegetableDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(DeleteBeet request, CancellationToken cancellationToken)
        {
            var beet = await _dbContext.Beets.FindAsync(new object[] { request.ItemId }, cancellationToken);

            if (beet is null || request.PersonId != beet.PersonId)
            {
                throw new NotImplementedException();
            }

            _dbContext.Beets.Remove(beet);

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
