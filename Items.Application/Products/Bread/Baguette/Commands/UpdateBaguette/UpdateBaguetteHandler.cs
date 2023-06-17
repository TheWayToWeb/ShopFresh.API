using Items.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Items.Application.Products.Bread.Baguette.Commands.UpdateBaguette
{
    public class UpdateBaguetteHandler : IRequestHandler<UpdateBaguette, Unit>
    {
        private readonly IBreadDbContext _dbContext;

        public UpdateBaguetteHandler(IBreadDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(UpdateBaguette request, CancellationToken cancellationToken)
        {
            var baguette = await _dbContext.Baguettes.FirstOrDefaultAsync(item => item.ItemId == request.ItemId, cancellationToken);

            if (baguette is null || request.PersonId != baguette.PersonId) {
                throw new NotImplementedException();
            }

            baguette.ItemName = request.ItemName;
            baguette.Price = request.Price;
            baguette.ImagePath = request.ImagePath;
            baguette.Maker = request.Maker;
            baguette.MinTemp = request.MinTemp;
            baguette.MaxTemp = request.MaxTemp;
            baguette.Protein = request.Protein;
            baguette.Fat = request.Fat;
            baguette.Sugar = request.Sugar;
            baguette.Energy = request.Energy;
            baguette.CountInPackage = request.CountInPackage;
            baguette.ProductExpiryDate = request.ProductExpiryDate;
            baguette.Weight = request.Weight;
            baguette.IsFarmer = request.IsFarmer;

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
