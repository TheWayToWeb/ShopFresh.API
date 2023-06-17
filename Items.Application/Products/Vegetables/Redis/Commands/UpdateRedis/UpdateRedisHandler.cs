using Items.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace Items.Application.Products.Vegetables.Redis.Commands.UpdateRedis
{
    public class UpdateRedisHandler : IRequestHandler<UpdateRedis, Unit>
    {
        private readonly IVegetableDbContext _dbContext;

        public UpdateRedisHandler(IVegetableDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(UpdateRedis request, CancellationToken cancellationToken)
        {
            var redis = await _dbContext.Redises.FirstOrDefaultAsync(item => item.ItemId == request.ItemId, cancellationToken);

            if (redis is null || request.PersonId != redis.PersonId) {
                throw new NotImplementedException();
            }

            redis.ItemName = request.ItemName;
            redis.Price = request.Price;
            redis.ImagePath = request.ImagePath;
            redis.Maker = request.Maker;
            redis.MinTemp = request.MinTemp;
            redis.MaxTemp = request.MaxTemp;
            redis.Protein = request.Protein;
            redis.Fat = request.Fat;
            redis.Sugar = request.Sugar;
            redis.Energy = request.Energy;
            redis.CountInPackage = request.CountInPackage;
            redis.ProductExpiryDate = request.ProductExpiryDate;
            redis.Weight = request.Weight;
            redis.CoolingMode = request.CoolingMode;
            redis.IsFarmer = request.IsFarmer;
            redis.Sort = request.Sort;
            redis.IsSlicingShape = false;
            redis.SkinColor = request.SkinColor;

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
