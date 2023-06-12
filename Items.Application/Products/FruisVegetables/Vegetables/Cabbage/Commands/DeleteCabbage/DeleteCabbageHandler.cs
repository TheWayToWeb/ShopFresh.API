using Items.Application.Interfaces;
using MediatR;

namespace Items.Application.Products.FruisVegetables.Vegetables.Cabbage.Commands.DeleteCabbage
{
    public class DeleteCabbageHandler : IRequestHandler<DeleteCabbage, Unit>
    {
        private readonly IVegetableDbContext _dbContext;

        public DeleteCabbageHandler(IVegetableDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(DeleteCabbage request, CancellationToken cancellationToken)
        {
            var cabbage = await _dbContext.Сabbage.FindAsync(new object[] { request.ItemId }, cancellationToken);

            if (cabbage is null || request.PersonId != cabbage.PersonId)
            {
                throw new NotImplementedException();
            }

            _dbContext.Сabbage.Remove(cabbage);

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
