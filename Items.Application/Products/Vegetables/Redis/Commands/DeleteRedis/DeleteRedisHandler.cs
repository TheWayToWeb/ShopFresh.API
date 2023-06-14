using Items.Application.Interfaces;
using MediatR;

namespace Items.Application.Products.Vegetables.Redis.Commands.DeleteRedis
{
    public class DeleteRedisHandler : IRequestHandler<DeleteRedis, Unit>
    {
        private readonly IVegetableDbContext _dbContext;

        public DeleteRedisHandler(IVegetableDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(DeleteRedis request, CancellationToken cancellationToken)
        {
            var redis = await _dbContext.Redises.FindAsync(new object[] { request.ItemId }, cancellationToken);

            if (redis is null || request.PersonId != redis.PersonId)
            {
                throw new NotImplementedException();
            }

            _dbContext.Redises.Remove(redis);

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
