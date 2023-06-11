using Items.Application.Interfaces;
using MediatR;

namespace Items.Application.Products.FruisVegetables.Fruits.CreateApple.Commands.DeleteApple
{
    public class DeleteAppleHandler : IRequestHandler<DeleteApple, Unit>
    {
        private readonly IFruitDbContext _dbContext;

        public DeleteAppleHandler(IFruitDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(DeleteApple request, CancellationToken cancellationToken)
        {
            var apple = await _dbContext.Apples.FindAsync(new object[] { request.ItemId }, cancellationToken);

            if (apple is null || request.PersonId != apple.PersonId) {
                throw new NotImplementedException();
            }

            _dbContext.Apples.Remove(apple);

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
