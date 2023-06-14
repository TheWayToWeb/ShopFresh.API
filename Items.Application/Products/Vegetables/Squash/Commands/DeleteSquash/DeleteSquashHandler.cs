using Items.Application.Interfaces;
using MediatR;

namespace Items.Application.Products.Vegetables.Squash.Commands.DeleteSquash
{
    public class DeleteSquashHandler : IRequestHandler<DeleteSquash, Unit>
    {
        private readonly IVegetableDbContext _dbContext;

        public DeleteSquashHandler(IVegetableDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(DeleteSquash request, CancellationToken cancellationToken)
        {
            var squash = await _dbContext.Squashes.FindAsync(new object[] { request.ItemId }, cancellationToken);

            if (squash is null || request.PersonId != squash.ItemId)
            {
                throw new NotImplementedException();
            }

            _dbContext.Squashes.Remove(squash);

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
