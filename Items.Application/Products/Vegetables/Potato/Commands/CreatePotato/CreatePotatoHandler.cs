using Items.Application.Interfaces;
using SelfPotato = Items.Domain.Products.FreshItem.FruitsVegetables.Vegetables.Potato;
using MediatR;

namespace Items.Application.Products.Vegetables.Potato.Commands.CreatePotato
{
    public class CreatePotatoHandler : IRequestHandler<CreatePotato, Guid>
    {
        private readonly IVegetableDbContext _dbContext;

        public CreatePotatoHandler(IVegetableDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreatePotato request, CancellationToken cancellationToken)
        {
            var potato = new SelfPotato
            {
                PersonId = request.PersonId,
                ItemId = Guid.NewGuid(),
                ItemName = request.ItemName,
                Price = request.Price,
                ImagePath = request.ImagePath,
                Maker = null,
                MinTemp = request.MinTemp,
                MaxTemp = request.MaxTemp,
                Protein = 0,
                Fat = request.Fat,
                Sugar = request.Sugar,
                Energy = request.Energy,
                CountInPackage = request.CountInPackage,
                ProductExpiryDate = request.ProductExpiryDate,
                Weight = null,
                CoolingMode = request.CoolingMode,
                IsFarmer = false,
                Sort = request.Sort,
                IsSlicingShape = request.IsSlicingShape,
                SaleWeights = request.SaleWeights,
                IsWash = request.IsWash
            };

            await _dbContext.Potatos.AddAsync(potato, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return potato.ItemId;
        }
    }
}
