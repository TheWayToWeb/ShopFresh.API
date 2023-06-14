using Items.Application.Interfaces;
using SelfCarrot = Items.Domain.Products.FreshItem.FruitsVegetables.Vegetables.Carrot;
using MediatR;

namespace Items.Application.Products.Vegetables.Carrot.Commands.CreateCarrot
{
    public class CreateCarrotHandler : IRequestHandler<CreateCarrot, Guid>
    {
        private readonly IVegetableDbContext _dbContext;

        public CreateCarrotHandler(IVegetableDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateCarrot request, CancellationToken cancellationToken)
        {
            var carrot = new SelfCarrot
            {
                PersonId = request.PersonId,
                ItemId = Guid.NewGuid(),
                ItemName = request.ItemName,
                Price = request.Price,
                ImagePath = request.ImagePath,
                MinTemp = request.MinTemp,
                MaxTemp = request.MaxTemp,
                Protein = request.Protein,
                Sugar = request.Sugar,
                Energy = request.Energy,
                CountInPackage = request.CountInPackage,
                ProductExpiryDate = request.ProductExpiryDate,
                Sort = request.Sort,
                SaleWeights = request.SaleWeights,
                IsWash = request.IsWash,
                SlicingShape = request.SlicingShape
            };

            await _dbContext.Carrots.AddAsync(carrot, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return carrot.ItemId;
        }
    }
}
