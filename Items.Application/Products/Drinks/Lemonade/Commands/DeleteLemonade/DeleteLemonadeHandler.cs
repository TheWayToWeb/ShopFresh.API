using Items.Application.Interfaces;
using MediatR;

namespace Items.Application.Products.Drinks.Lemonade.Commands.DeleteLemonade
{
    public class DeleteLemonadeHandler : IRequestHandler<DeleteLemonade, Unit>
    {
        private readonly IDrinkDbContext _dbContext;

        public DeleteLemonadeHandler(IDrinkDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(DeleteLemonade request, CancellationToken cancellationToken)
        {
            var lemonade = await _dbContext.Lemonades.FindAsync(new object[] { request.Itemid }, cancellationToken);

            if (lemonade is null || request.PersonId != lemonade.PersonId) {
                throw new NotImplementedException();
            }

            _dbContext.Lemonades.Remove(lemonade);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
