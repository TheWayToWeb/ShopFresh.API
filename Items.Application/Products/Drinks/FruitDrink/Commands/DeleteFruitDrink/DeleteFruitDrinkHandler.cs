using Items.Application.Interfaces;
using MediatR;

namespace Items.Application.Products.Drinks.FruitDrink.Commands.DeleteFruitDrink
{
    public class DeleteFruitDrinkHandler : IRequestHandler<DeleteFruitDrink, Unit>
    {
        private readonly IDrinkDbContext _dbContext;

        public DeleteFruitDrinkHandler(IDrinkDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(DeleteFruitDrink request, CancellationToken cancellationToken)
        {
            var fruitDrink = await _dbContext.FruitDrink.FindAsync(new object[] { request.ItemId }, cancellationToken);

            if (fruitDrink is null || request.PersonId != fruitDrink.PersonId) {
                throw new NotImplementedException();
            }
            _dbContext.FruitDrink.Remove(fruitDrink);

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
