using Items.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Items.Application.Products.Vegetables.Beet.Commands.UpdateBeet
{
    public class UpdateBeetHandler : IRequestHandler<UpdateBeet, Unit>
    {
        private readonly IVegetableDbContext _dbContext;

        public UpdateBeetHandler(IVegetableDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(UpdateBeet request, CancellationToken cancellationToken)
        {
            var beet = await _dbContext.Beets.FirstOrDefaultAsync(item => item.ItemId == request.ItemId, cancellationToken);

            if (beet is null || request.PersonId != beet.PersonId) {
                throw new NotImplementedException();
            }

            beet.ItemName = request.ItemName;
            beet.Price = request.Price;
            beet.ImagePath = request.ImagePath;
            beet.MinTemp = request.MinTemp;
            beet.MaxTemp = request.MaxTemp;
            beet.Protein = request.Protein;
            beet.Fat = request.Fat;
            beet.Sugar = request.Sugar;
            beet.Energy = request.Energy;
            beet.CountInPackage = request.CountInPackage;
            beet.ProductExpiryDate = request.ProductExpiryDate;
            beet.Weight = request.Weight;
            beet.CoolingMode = request.CoolingMode;
            beet.IsFarmer = request.IsFarmer;
            beet.Sort = request.Sort;
            beet.IsSlicingShape = request.IsSlicingShape;

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
