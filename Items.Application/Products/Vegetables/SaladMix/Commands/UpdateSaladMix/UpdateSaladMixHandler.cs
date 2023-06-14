using Items.Application.Interfaces;
using Items.Domain.Products.FreshItem.Drinks;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Items.Application.Products.Vegetables.SaladMix.Commands.UpdateSaladMix
{
    public class UpdateSaladMixHandler : IRequestHandler<UpdateSaladMix, Unit>
    {
        private readonly IVegetableDbContext _dbContext;

        public UpdateSaladMixHandler(IVegetableDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(UpdateSaladMix request, CancellationToken cancellationToken)
        {
            var saladMix = await _dbContext.SaladMixes.FirstOrDefaultAsync(item => item.ItemId == request.ItemId, cancellationToken);

            if (saladMix is null || request.PersonId != saladMix.PersonId)
            {
                throw new NotImplementedException();
            }

            saladMix.ItemName = request.ItemName;
            saladMix.Price = request.Price;
            saladMix.ImagePath = request.ImagePath;
            saladMix.MinTemp = request.MinTemp;
            saladMix.MaxTemp = request.Maxtemp;
            saladMix.Protein = request.Protein;
            saladMix.Fat = request.Fat;
            saladMix.Sugar = request.Sugar;
            saladMix.Energy = request.Energy;
            saladMix.CountInPackage = request.CountInPackage;
            saladMix.ProductExpiryDate = request.ProductExpiryDate;
            saladMix.CoolingMode = request.CoolingMode;
            saladMix.IsSlicingShape = request.IsSlicingShape;
            saladMix.GreeneryKinds = request.GreeneryKinds;

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
