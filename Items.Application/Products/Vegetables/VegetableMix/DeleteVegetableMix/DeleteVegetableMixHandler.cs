using Items.Application.Interfaces;
using MediatR;

namespace Items.Application.Products.Vegetables.VegetableMix.DeleteVegetableMix
{
    public class DeleteVegetableMixHandler : IRequestHandler<DeleteVegetableMix, Unit>
    {
        private readonly IVegetableDbContext _dbContext;

        public DeleteVegetableMixHandler(IVegetableDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(DeleteVegetableMix request, CancellationToken cancellationToken)
        {
            var vegetableMix = await _dbContext.VegetableMixes.FindAsync(new object[] { request.ItemId }, cancellationToken);

            if (vegetableMix is null || request.PersonId != vegetableMix.PersonId) {
                throw new NotImplementedException();
            }

            _dbContext.VegetableMixes.Remove(vegetableMix);

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
