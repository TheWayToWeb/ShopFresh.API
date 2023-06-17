using Items.Application.Interfaces;
using MediatR;

namespace Items.Application.Products.Bread.CottageCheesePatty.Commands.DeleteCottagePatty
{
    public class DeleteCottagePattyHandler : IRequestHandler<DeleteCottagePatty, Unit>
    {
        private readonly IBreadDbContext _dbContext;

        public DeleteCottagePattyHandler(IBakeryDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(DeleteCottagePatty request, CancellationToken cancellationToken)
        {
            var cottagePatty = await _dbContext.CottageCheesePatties.FindAsync(new object[] { request.ItemId }, cancellationToken);

            if (cottagePatty is null || request.PersonId != cottagePatty.PersonId) {
                throw new NotImplementedException();
            }

            _dbContext.CottageCheesePatties.Remove(cottagePatty);

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
