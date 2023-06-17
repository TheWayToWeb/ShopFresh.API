using Items.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Items.Application.Products.Vegetables.Potato.Commands.UpdatePotato
{
    public class UpdatePotatoHandler : IRequestHandler<UpdatePotato, Unit>
    {
        private readonly IVegetableDbContext _dbContext;

        public UpdatePotatoHandler(IVegetableDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(UpdatePotato request, CancellationToken cancellationToken)
        {
            var potato = await _dbContext.Potatos.FirstOrDefaultAsync(item => item.ItemId == request.ItemId, cancellationToken);

            if (potato is null || request.PersonId != potato.PersonId) {
                throw new NotImplementedException();
            }

            potato.ItemName = request.ItemName;
            potato.Price = request.Price;
            potato.ImagePath = request.ImagePath;
            potato.Maker = request.Maker;
            potato.MinTemp = request.MinTemp;
            potato.MaxTemp = request.Maxtemp;
            potato.Protein = request.Protein;
            potato.Fat = request.Fat;
            potato.Sugar = request.Sugar;
            potato.Energy = request.Energy;
            potato.CountInPackage = request.CountInPackage;
            potato.ProductExpiryDate = request.ProductExpiryDate;
            potato.CoolingMode = request.CoolingMode;
            potato.IsFarmer = request.IsFarmer;
            potato.Sort = request.Sort;
            potato.IsSlicingShape = request.IsSlicingShape;

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
