using Items.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Items.Application.Products.Vegetables.Broccoli.UpdateBroccoli
{
    public class UpdateBroccoliHandler : IRequestHandler<UpdateBroccoli, Unit>
    {
        private readonly IVegetableDbContext _dbContext;

        public UpdateBroccoliHandler(IVegetableDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(UpdateBroccoli request, CancellationToken cancellationToken)
        {
            var broocoli = await _dbContext.Broccoli.FirstOrDefaultAsync(item => item.ItemId == request.ItemId, cancellationToken);

            if (broocoli is null || request.PersonId != broocoli.PersonId) {
                throw new NotImplementedException();
            }

            broocoli.ItemName = request.ItemName;
            broocoli.Price = request.Price;
            broocoli.ImagePath = request.ImagePath;
            broocoli.Maker = request.Maker;
            broocoli.MinTemp = request.MinTemp;
            broocoli.MaxTemp = request.MaxTemp;
            broocoli.Protein = request.Protein;
            broocoli.Fat = request.Fat;
            broocoli.Sugar = request.Sugar;
            broocoli.Energy = request.Energy;
            broocoli.CountInPackage = request.CountInPackage;
            broocoli.ProductExpiryDate = request.ProductExpiryDate;
            broocoli.Weight = request.Weight;
            broocoli.CoolingMode = request.CoolingMode;

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
