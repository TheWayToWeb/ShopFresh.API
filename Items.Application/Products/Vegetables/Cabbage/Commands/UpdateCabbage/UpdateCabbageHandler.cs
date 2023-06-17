using Items.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Items.Application.Products.Vegetables.Cabbage.Commands.UpdateCabbage
{
    public class UpdateCabbageHandler : IRequestHandler<UpdateCabbage, Unit>
    {
        private readonly IVegetableDbContext _dbContext;

        public UpdateCabbageHandler(IVegetableDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(UpdateCabbage request, CancellationToken cancellationToken)
        {
            var cabbage = await _dbContext.Сabbage.FirstOrDefaultAsync(item => item.ItemId == request.ItemId, cancellationToken);

            if (cabbage is null || request.PersonId != cabbage.PersonId) {
                throw new NotImplementedException();
            }

            cabbage.ItemName = request.ItemName;
            cabbage.Price = request.Price;
            cabbage.ImagePath = request.ImagePath;
            cabbage.Maker = request.Maker;
            cabbage.MinTemp = request.MinTemp;
            cabbage.MaxTemp = request.MaxTemp;
            cabbage.Protein = request.Protein;
            cabbage.Fat = request.Fat;
            cabbage.Sugar = request.Sugar;
            cabbage.Energy = request.Energy;
            cabbage.CountInPackage = request.CountInPackage;
            cabbage.ProductExpiryDate = request.ProductExpiryDate;
            cabbage.Weight = request.Weight;
            cabbage.IsFarmer = request.IsFarmer;
            cabbage.Sort = request.Sort;

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
