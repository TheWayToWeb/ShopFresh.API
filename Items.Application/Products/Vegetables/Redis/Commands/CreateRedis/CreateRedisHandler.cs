using Items.Application.Interfaces;
using SelfRedis = Items.Domain.Products.FreshItem.FruitsVegetables.Vegetables.Redis;
using MediatR;

namespace Items.Application.Products.Vegetables.Redis.Commands.CreateRedis
{
    public class CreateRedishandler : IRequestHandler<CreateRedis, Guid>
    {
        private readonly IVegetableDbContext _dbContext;

        public CreateRedishandler(IVegetableDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateRedis request, CancellationToken cancellationToken)
        {
            var redis = new SelfRedis
            {
                PersonId = request.PersonId,
                ItemId = Guid.NewGuid(),
                ItemName = request.ItemName,
                Price = request.Price,
                ImagePath = request.ImagePath,
                Maker = null,
                MinTemp = request.MinTemp,
                MaxTemp = request.MaxTemp,
                Protein = request.Protein,
                Fat = request.Fat,
                Sugar = request.Sugar,
                Energy = request.Energy,
                CountInPackage = request.CountInPackage,
                ProductExpiryDate = request.ProductExpiryDate,
                Weight = request.Weight,
                CoolingMode = request.CoolingMode,
                IsFarmer = false,
                Sort = request.Sort,
                SkinColor = null
            };

            await _dbContext.Redises.AddAsync(redis, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return redis.ItemId;
        }
    }
}
