using Items.Application.Interfaces;
using Items.Domain.Products.FreshItem.FruitsVegetables.Vegetables;
using MediatR;

namespace Items.Application.Products.Vegetables.CreateCarrot
{
    public class CreateCarrotHandler : IRequestHandler<CreateCarrot, Guid>
    {
        private readonly IVegetableDbContext _dbContext;

        public CreateCarrotHandler(IVegetableDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateCarrot request, CancellationToken cancellationToken)
        {
            var carrot = new Carrot
            {
                PersonId = Guid.NewGuid(),
                ItemId = Guid.NewGuid(),
                ItemName = request.ItemName,
                BrandId = Guid.NewGuid(),
                Price = request.Price,
                ImagePath = request.ImagePath,
                MinTemp = request.MinTemp,
                MaxTemp = request.MaxTemp,
                Weight = request.Weight,
                Protein = request.Protein,
                Fat = request.Fat,
                Sugar = request.Sugar,
                Energy = request.Energy,
                CountInPackage = request.CountInPackage,
                BeforeDate = request.BeforeDate,
                ShortName = request.ShortName,
                Grade = request.Grade,
                SaleWeights = request.SaleWeights,
                IsWash = request.IsWash
            };

            await _dbContext.Carrots.AddAsync(carrot, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return carrot.ItemId;
        }
    }
}
