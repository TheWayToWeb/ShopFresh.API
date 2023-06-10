using Items.Application.Interfaces;
using MediatR;

namespace Items.Application.Products.Drinks.SoyMilk.Commands.DeleteSoyMilk
{
    public class DeleteSoyMilkHandler : IRequestHandler<DeleteSoyMilk, Unit>
    {
        private readonly IDrinkDbContext _dbContext;

        public DeleteSoyMilkHandler(IDrinkDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(DeleteSoyMilk request, CancellationToken cancellationToken)
        {
            var soyMilk = await _dbContext.SoyMilk.FindAsync(new object[] { request.ItemId }, cancellationToken);

            if (soyMilk is null || request.PersonId != soyMilk.PersonId) {
                throw new NotImplementedException();
            }

            _dbContext.SoyMilk.Remove(soyMilk);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
