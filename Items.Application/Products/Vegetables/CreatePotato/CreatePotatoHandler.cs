using Items.Application.Interfaces;
using Items.Domain.Products.FreshItem.FruitsVegetables.Vegetables;
using MediatR;

namespace Items.Application.Products.Vegetables.CreatePotato
{
    public class CreatePotatoHandler : IRequestHandler<CreatePotato, Guid>
    {
        private readonly IVegetableDbContext _dbContext;

        public CreatePotatoHandler(IVegetableDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreatePotato request, CancellationToken cancellationToken)
        {
            var potato = new Potato
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

            await _dbContext.Potatos.AddAsync(potato, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return potato.ItemId;
        }
    }
}
