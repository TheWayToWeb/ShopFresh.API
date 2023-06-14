using Items.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Items.Application.Products.Vegetables.Cauliflower.Commands.UpdateCauliflower
{
    public class UpdateCauliflowerHandler : IRequestHandler<UpdateCauliflower, Unit>
    {
        private readonly IVegetableDbContext _dbContext;

        public UpdateCauliflowerHandler(IVegetableDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(UpdateCauliflower request, CancellationToken cancellationToken)
        {
            var cauliflower = await _dbContext.Cauliflowers.FirstOrDefaultAsync(item => item.ItemId == request.ItemId, cancellationToken);

            if (cauliflower is null || request.PersonId != cauliflower.PersonId) {
                throw new NotImplementedException();
            }

            cauliflower.ItemName = request.ItemName;
            cauliflower.Price = request.Price;
            cauliflower.ImagePath = request.ImagePath;
            cauliflower.MinTemp = request.MinTemp;
            cauliflower.MaxTemp = request.MaxTemp;
            cauliflower.Protein = request.Protein;
            cauliflower.Fat = request.Fat;
            cauliflower.Sugar = request.Sugar;
            cauliflower.Energy = request.Energy;
            cauliflower.CountInPackage = request.CountInPackage;
            cauliflower.ProductExpiryDate = request.ProductExpiryDate;
            cauliflower.Weight = request.Weight;
            cauliflower.CoolingMode = request.CoolingMode;
            cauliflower.IsFarmer = request.IsFarmer;
            cauliflower.Sort = request.Sort;

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
