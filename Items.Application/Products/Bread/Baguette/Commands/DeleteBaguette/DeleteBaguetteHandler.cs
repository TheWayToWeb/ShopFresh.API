using Items.Application.Interfaces;
using MediatR;

namespace Items.Application.Products.Bread.Baguette.Commands.DeleteBaguette
{
    public class DeleteBaguetteHandler : IRequestHandler<DeleteBaguette, Unit>
    {
        private readonly IBreadDbContext _dbContext;

        public DeleteBaguetteHandler(IBreadDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(DeleteBaguette request, CancellationToken cancellationToken)
        {
            var baguette = await _dbContext.Baguettes.FindAsync(new object[] { request.ItemId }, cancellationToken);

            if (baguette is null || request.PersonId != baguette.PersonId) {
                throw new NotImplementedException();
            }

            _dbContext.Baguettes.Remove(baguette);

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
