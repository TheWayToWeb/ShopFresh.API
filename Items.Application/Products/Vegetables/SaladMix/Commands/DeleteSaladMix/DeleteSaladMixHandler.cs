using Items.Application.Interfaces;
using MediatR;

namespace Items.Application.Products.Vegetables.SaladMix.Commands.DeleteSaladMix
{
    public class DeleteSaladMixHandler : IRequestHandler<DeleteSaladMix, Unit>
    {
        private readonly IVegetableDbContext _dbContext;

        public DeleteSaladMixHandler(IVegetableDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(DeleteSaladMix request, CancellationToken cancellationToken)
        {
            var saladMix = await _dbContext.SaladMixes.FindAsync(new object[] { request.ItemId }, cancellationToken);

            if (saladMix is null || request.PersonId != saladMix.PersonId)
            {
                throw new NotImplementedException();
            }

            _dbContext.SaladMixes.Remove(saladMix);

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
