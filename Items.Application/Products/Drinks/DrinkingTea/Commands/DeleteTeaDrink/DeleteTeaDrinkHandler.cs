using Items.Application.Interfaces;
using MediatR;

namespace Items.Application.Products.Drinks.TeaDrink.Commands.DeleteTeaDrink
{
    public class DeleteTeaDrinkHandler : IRequestHandler<DeleteTeaDrink, Unit>
    {
        private readonly IDrinkDbContext _dbContext;

        public DeleteTeaDrinkHandler(IDrinkDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(DeleteTeaDrink request, CancellationToken cancellationToken)
        {
            var teaDrink = await _dbContext.TeaDrinks.FindAsync(new object[] { request.ItemId }, cancellationToken);

            if (teaDrink is null || request.PersonId != teaDrink.PersonId)
            {
                throw new NotImplementedException();
            }

            _dbContext.TeaDrinks.Remove(teaDrink);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
