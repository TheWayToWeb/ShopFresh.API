using Items.Application.Interfaces;
using MediatR;

namespace Items.Application.ItemsFood.Commands.DeleteItemFood
{
    public class DeleteItemFoodRequestHandler : IRequestHandler<DeleteItemFoodRequest, Unit>
    {
        private readonly IItemFoodDbContext _dbContext;

        public DeleteItemFoodRequestHandler(IItemFoodDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(DeleteItemFoodRequest request, CancellationToken cancellationToken)
        {
            var itemFood = await _dbContext.ItemFoods.FindAsync(new object[] { request.ItemId }, cancellationToken) ?? throw new NotImplementedException();

            _dbContext.ItemFoods.Remove(itemFood);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
