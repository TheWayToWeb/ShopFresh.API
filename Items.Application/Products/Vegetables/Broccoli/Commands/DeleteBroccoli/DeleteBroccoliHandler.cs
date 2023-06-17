using Items.Application.Interfaces;
using MediatR;

namespace Items.Application.Products.Vegetables.Broccoli.Commands.DeleteBroccoli
{
    public class DeleteBroccoliHandler : IRequestHandler<DeleteBroccoli, Unit>
    {
        private readonly IVegetableDbContext _dbContext;

        public DeleteBroccoliHandler(IVegetableDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(DeleteBroccoli request, CancellationToken cancellationToken)
        {
            var broccoli = await _dbContext.Broccoli.FindAsync(new object[] { request.ItemId }, cancellationToken);

            if (broccoli is null || request.PersonId != broccoli.PersonId)
            {
                throw new NotImplementedException();
            }

            _dbContext.Broccoli.Remove(broccoli);

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
