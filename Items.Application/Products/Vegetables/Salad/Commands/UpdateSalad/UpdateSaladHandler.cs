using Items.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Items.Application.Products.Vegetables.Salad.Commands.UpdateSalad
{
    public class UpdateSaladHandler : IRequestHandler<UpdateSalad, Unit>
    {
        private readonly IVegetableDbContext _dbContext;

        public UpdateSaladHandler(IVegetableDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(UpdateSalad request, CancellationToken cancellationToken)
        {
            var salad = await _dbContext.Salads.FirstOrDefaultAsync(item => item.ItemId == request.ItemId, cancellationToken);

            if (salad is null || request.PersonId != salad.PersonId) {
                throw new NotImplementedException();
            }

            salad.ItemName = request.ItemName;
            salad.Price = request.Price;
            salad.ImagePath = request.ImagePath;
            salad.Maker = request.Maker;
            salad.MinTemp = request.MinTemp;
            salad.MaxTemp = request.MaxTemp;
            salad.Protein = request.Protein;
            salad.Fat = request.Fat;
            salad.Sugar = request.Sugar;
            salad.Energy = request.Energy;
            salad.CountInPackage = request.CountInPackage;
            salad.ProductExpiryDate = request.ProductExpiryDate;
            salad.CoolingMode = request.CoolingMode;
            salad.IsFarmer = request.IsFarmer;
            salad.Sort = request.Sort;
            salad.IsSlicingShape = request.IsSlicingShape;

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
