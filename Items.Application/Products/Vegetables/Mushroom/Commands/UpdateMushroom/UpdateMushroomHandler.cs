using Items.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Items.Application.Products.Vegetables.Mushroom.Commands.UpdateMushroom
{
    public class UpdateMushroomHandler : IRequestHandler<UpdateMushroom, Unit>
    {
        private readonly IVegetableDbContext _dbContext;

        public UpdateMushroomHandler(IVegetableDbContext dbConext) {
            _dbContext = dbConext;
        }

        public async Task<Unit> Handle(UpdateMushroom request, CancellationToken cancellationToken)
        {
            var mushroom = await _dbContext.Mushrooms.FirstOrDefaultAsync(item => item.ItemId == request.ItemId, cancellationToken);

            if (mushroom is null || request.PersonId != mushroom.PersonId) {
                throw new NotImplementedException();
            }

            mushroom.ItemName = request.ItemName;
            mushroom.Price = request.Price;
            mushroom.ImagePath = request.ImagePath;
            mushroom.Maker = request.Maker;
            mushroom.MinTemp = request.MinTemp;
            mushroom.MaxTemp = request.MaxTemp;
            mushroom.Protein = request.Protein;
            mushroom.Fat = request.Fat;
            mushroom.Sugar = request.Sugar;
            mushroom.Energy = request.Energy;
            mushroom.CountInPackage = request.CountInPackage;
            mushroom.ProductExpiryDate = request.ProductExpiryDate;
            mushroom.Weight = request.Weight;
            mushroom.CoolingMode = request.CoolingMode;
            mushroom.Sort = request.Sort;
            mushroom.IsSlicingShape = request.IsSlicingShape;

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
