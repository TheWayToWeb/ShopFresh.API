using Items.Application.Interfaces;
using Items.Domain.Products.Category.SubCategory.FreshGroup.FreshItem.FruitsVegetables.Vegetables;
using MediatR;

namespace Items.Application.Products.Vegetables.CreateRedis
{
    public class CreateRedishandler : IRequestHandler<CreateRedis, Guid>
    {
        private readonly IVegetableDbContext _dbContext;

        public CreateRedishandler(IVegetableDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateRedis request, CancellationToken cancellationToken)
        {
            var redis = new Redis
            {
                PersonId = Guid.NewGuid(),
                ItemId = Guid.NewGuid(),
                ItemName = request.ItemName,
                Brand = request.Brand,
                Price = request.Price,
                ImagePath = request.ImagePath,
                MinTemp = request.MinTemp,
                MaxTemp = request.MaxTemp,
                Weight = request.Weight,
                Capacities = null,
                Protein = request.Protein,
                Fat = request.Fat,
                Sugar = request.Sugar,
                Energy = request.Energy,
                CountInPackage = request.CountInPackage,
                BeforeDate = request.BeforeDate,
                ShortName = request.ShortName,
                Grade = request.Grade,
                SkinColor = request.SkinColor
            };

            await _dbContext.Redises.AddAsync(redis, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return redis.ItemId;
        }
    }
}
