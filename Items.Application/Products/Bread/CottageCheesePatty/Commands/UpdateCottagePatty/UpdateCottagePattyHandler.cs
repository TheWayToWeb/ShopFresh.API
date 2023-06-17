using Items.Application.Interfaces;
using MediatR;

namespace Items.Application.Products.Bread.CottageCheesePatty.Commands.UpdateCottagePatty
{
    public class UpdateCottagePattyHandler : IRequestHandler<UpdateCottagePatty, Unit>
    {
        private readonly IBreadDbContext _dbContext;

        public UpdateCottagePattyHandler(IBreadDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(UpdateCottagePatty request, CancellationToken cancellationToken)
        {
            var cottagePatty = await _dbContext.CottageCheesePatties.FindAsync(new object[] { request.ItemId }, cancellationToken);

            if (cottagePatty is null || request.PersonId != cottagePatty.PersonId) {
                throw new NotImplementedException();
            }

            cottagePatty.ItemName = request.ItemName;
            cottagePatty.Maker = request.Maker;
            cottagePatty.Price = request.Price;
            cottagePatty.ImagePath = request.ImagePath;
            cottagePatty.MinTemp = request.MinTemp;
            cottagePatty.MaxTemp = request.MaxTemp;
            cottagePatty.Protein = request.Protein;
            cottagePatty.Fat = request.Fat;
            cottagePatty.Sugar = request.Sugar;
            cottagePatty.Energy = request.Energy;
            cottagePatty.CountInPackage = request.CountInPackage;
            cottagePatty.ProductExpiryDate = request.ProductExpiryDate;
            cottagePatty.Weight = request.Weight;

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
