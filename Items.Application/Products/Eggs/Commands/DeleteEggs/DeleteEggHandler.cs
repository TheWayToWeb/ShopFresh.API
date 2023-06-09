using Items.Application.Interfaces;
using MediatR;

namespace Items.Application.Products.Eggs.Commands.DeleteEggs
{
    public class DeleteEggHandler : IRequestHandler<DeleteEgg, Unit>
    {
        private readonly IMilkDbContext _dbContext;

        public DeleteEggHandler(IMilkDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(DeleteEgg request, CancellationToken cancellationToken)
        {
            var egg = await _dbContext.Eggs.FindAsync(new object[] { request.ItemId }, cancellationToken);

            if (egg is null || request.PersonId != egg.PersonId) {
                throw new NotImplementedException();
            }

            _dbContext.Eggs.Remove(egg);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
