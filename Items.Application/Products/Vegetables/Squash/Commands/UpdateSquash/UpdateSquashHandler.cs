using Items.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Items.Application.Products.Vegetables.Squash.Commands.UpdateSquash
{
    public class UpdateSquashHandler : IRequestHandler<UpdateSquash, Unit>
    {
        private readonly IVegetableDbContext _dbContext;

        public UpdateSquashHandler(IVegetableDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(UpdateSquash request, CancellationToken cancellationToken)
        {
            var squash = await _dbContext.Squashes.FirstOrDefaultAsync(item => item.ItemId == request.ItemId, cancellationToken);

            if (squash is null || request.PersonId != squash.PersonId) {
                throw new NotImplementedException();
            }

            squash.ItemName = request.ItemName;
            squash.Price = request.Price;
            squash.ImagePath = request.ImagePath;
            squash.Maker = request.Maker;
            squash.MinTemp = request.MinTemp;
            squash.MaxTemp = request.MaxTemp;
            squash.Protein = request.Protein;
            squash.Fat = request.Fat;
            squash.Sugar = request.Sugar;
            squash.Energy = request.Energy;
            squash.CountInPackage = request.CountInPackage;
            squash.ProductExpiryDate = request.ProductExpiryDate;
            squash.Weight = request.Weight;
            squash.Sort = request.Sort;
            squash.IsFarmer = request.IsFarmer;

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
