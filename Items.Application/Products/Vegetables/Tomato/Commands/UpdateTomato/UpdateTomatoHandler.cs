using Items.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Items.Application.Products.Vegetables.Tomato.Commands.UpdateTomato
{
    public class UpdateTomatoHandler : IRequestHandler<UpdateTomato, Unit>
    {
        private readonly IVegetableDbContext _dbContext;

        public UpdateTomatoHandler(IVegetableDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(UpdateTomato request, CancellationToken cancellationToken)
        {
            var tomato = await _dbContext.Tomatoes.FirstOrDefaultAsync(item => item.ItemId == request.ItemId, cancellationToken);

            if (tomato is null || request.PersonId != tomato.PersonId)
            {
                throw new NotImplementedException();
            }

            tomato.ItemName = request.ItemName;
            tomato.Price = request.Price;
            tomato.ImagePath = request.ImagePath;
            tomato.Maker = request.Maker;
            tomato.MinTemp = request.MinTemp;
            tomato.MaxTemp = request.MaxTemp;
            tomato.Protein = request.Protein;
            tomato.Fat = request.Fat;
            tomato.Sugar = request.Sugar;
            tomato.Energy = request.Energy;
            tomato.CountInPackage = request.CountInPackage;
            tomato.ProductExpiryDate = request.ProductExpiryDate;
            tomato.Weight = request.Weight;
            tomato.CoolingMode = request.CoolingMode;
            tomato.IsFarmer = request.IsFarmer;
            tomato.Sort = request.Sort;

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
