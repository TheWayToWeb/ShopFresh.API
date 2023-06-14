using Items.Application.Interfaces;
using SelfSalad = Items.Domain.Products.FreshItem.FruitsVegetables.Vegetables.Salad;
using MediatR;

namespace Items.Application.Products.Vegetables.Salad.Commands.CreateSalad
{
    public class CreateSaladHandler : IRequestHandler<CreateSalad, Guid>
    {
        private readonly IVegetableDbContext _dbContext;

        public CreateSaladHandler(IVegetableDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateSalad request, CancellationToken cancellationToken)
        {
            var salad = new SelfSalad
            {
                PersonId = Guid.NewGuid(),
                ItemId = Guid.NewGuid(),
                ItemName = request.ItemName,
                Price = request.Price,
                ImagePath = request.ImagePath,
                MinTemp = request.MinTemp,
                MaxTemp = request.MaxTemp,
                Protein = request.Protein,
                Energy = request.Energy,
                CountInPackage = request.CountInPackage,
                ProductExpiryDate = request.ProductExpiryDate,
                Sort = request.Sort
            };

            await _dbContext.Salads.AddAsync(salad, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return salad.ItemId;
        }
    }
}
