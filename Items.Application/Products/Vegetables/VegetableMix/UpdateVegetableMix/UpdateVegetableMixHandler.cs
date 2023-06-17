using Items.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Items.Application.Products.Vegetables.VegetableMix.UpdateVegetableMix
{
    public class UpdateVegetableMixHandler : IRequestHandler<UpdateVegetableMix, Unit>
    {
        private readonly IVegetableDbContext _dbContext;

        public UpdateVegetableMixHandler(IVegetableDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(UpdateVegetableMix request, CancellationToken cancellationToken)
        {
            var vegetableMix = await _dbContext.VegetableMixes.FirstOrDefaultAsync(item => item.ItemId == request.ItemId, cancellationToken);

            if (vegetableMix is null || request.PersonId != vegetableMix.PersonId) {
                throw new NotImplementedException();
            }

            vegetableMix.ItemName = request.ItemName;
            vegetableMix.Price = request.Price;
            vegetableMix.ImagePath = request.ImagePath;
            vegetableMix.Maker = request.Maker;
            vegetableMix.MinTemp = request.MinTemp;
            vegetableMix.MaxTemp = request.MaxTemp;
            vegetableMix.Protein = request.Protein;
            vegetableMix.Fat = request.Fat;
            vegetableMix.Sugar = request.Sugar;
            vegetableMix.Energy = request.Energy;
            vegetableMix.CountInPackage = request.CountInPackage;
            vegetableMix.Weight = request.Weight;
            vegetableMix.CoolingMode = request.CoolingMode;
            vegetableMix.IsFarmer = request.IsFarmer;
            vegetableMix.Vegetables = request.Vegetables;

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
