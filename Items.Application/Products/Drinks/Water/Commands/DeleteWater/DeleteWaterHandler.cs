using Items.Application.Interfaces;
using MediatR;

namespace Items.Application.Products.Drinks.Water.Commands.DeleteWater
{
    public class DeleteWaterHandler : IRequestHandler<DeleteWater, Unit>
    {
        private readonly IDrinkDbContext _dbContext;

        public DeleteWaterHandler(IDrinkDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(DeleteWater request, CancellationToken cancellationToken)
        {
            var water = await _dbContext.Water.FindAsync(new object[] { request.ItemId }, cancellationToken);

            if (water is null || request.PersonId != water.PersonId) {
                throw new NotImplementedException();
            }

            _dbContext.Water.Remove(water);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
