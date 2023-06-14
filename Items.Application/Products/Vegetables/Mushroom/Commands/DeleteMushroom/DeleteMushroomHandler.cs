using Items.Application.Interfaces;
using MediatR;

namespace Items.Application.Products.Vegetables.Mushroom.Commands.DeleteMushroom
{
    public class DeleteMushroomHandler : IRequestHandler<DeleteMushroom, Unit>
    {
        private readonly IVegetableDbContext _dbContext;

        public DeleteMushroomHandler(IVegetableDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(DeleteMushroom request, CancellationToken cancellationToken)
        {
            var mushroom = await _dbContext.Mushrooms.FindAsync(new object[] { request.ItemId }, cancellationToken);

            if (mushroom is null || request.PersonId != mushroom.PersonId)
            {
                throw new NotImplementedException();
            }
            _dbContext.Mushrooms.Remove(mushroom);

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
