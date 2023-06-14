using Items.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Items.Application.Products.Vegetables.Carrot.Commands.UpdateCarrot
{
    public class UpdateCarrotHandler : IRequestHandler<UpdateCarrot, Unit>
    {
        private readonly IVegetableDbContext _dbContext;

        public UpdateCarrotHandler(IVegetableDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(UpdateCarrot request, CancellationToken cancellationToken)
        {
            var carrot = await _dbContext.Carrots.FirstOrDefaultAsync(item => item.ItemId == request.ItemId, cancellationToken);

            if (carrot is null || request.PersonId != carrot.PersonId) {
                throw new NotImplementedException();
            }

            carrot.ItemName = request.ItemName;
            carrot.Price = request.Price;
            carrot.ImagePath = request.ImagePath;
            carrot.MinTemp = request.MinTemp;
            carrot.MaxTemp = request.MaxTemp;
            carrot.Protein = request.Protein;
            carrot.Fat = request.Fat;
            carrot.Sugar = request.Sugar;
            carrot.Energy = request.Energy;
            carrot.CountInPackage = request.CountInPackage;
            carrot.Weight = request.Weight;
            carrot.CoolingMode = request.CoolingMode;
            carrot.IsWash = request.IsWash;
            carrot.Sort = request.Sort;
            carrot.IsSlicingShape = request.IsSlicingShape;

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
