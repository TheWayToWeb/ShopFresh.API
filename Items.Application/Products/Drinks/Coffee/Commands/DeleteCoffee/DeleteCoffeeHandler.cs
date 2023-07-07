using Items.Application.Interfaces;
using MediatR;

namespace Items.Application.Products.Drinks.Coffee.Commands.DeleteCoffee
{
    public class DeleteCoffeeHandler : IRequestHandler<DeleteCoffee, Unit>
    {
        private readonly IDrinkDbContext _dbContext;

        public DeleteCoffeeHandler(IDrinkDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(DeleteCoffee request, CancellationToken cancellationToken)
        {
            var coffee = await _dbContext.Coffee.FindAsync(new object[] { request.ItemId }, cancellationToken);

            if (coffee is null || request.PersonId != coffee.PersonId) {
                throw new NotImplementedException();
            }

                  _dbContext.Coffee.Remove(coffee);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
