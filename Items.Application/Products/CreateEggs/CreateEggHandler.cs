using Items.Application.Interfaces;
using Items.Domain.Products.Category.SubCategory.ItemCategory.Items.Dairy_products_and_eggs;
using MediatR;

namespace Items.Application.Products.CreateEggs
{
    public class CreateEggHandler : IRequestHandler<CreateEgg, Guid>
    {
        private readonly IFruitDbContext _dbContext;

        public CreateEggHandler(IFruitDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateEgg request, CancellationToken cancellationToken)
        {
            var egg = new Egg
            {
                PersonId = Guid.NewGuid(),
                ItemId = Guid.NewGuid(),
                ItemName = request.ItemName,
                Brand = request.Brand,
                Price = request.Price,
                ImagePath = request.ImagePath,
                Maker = request.Maker,
                Count = request.Count,
                Kind = request.Kind,
                Category = request.Category,
                IsFarmer = request.IsFarmer
            };

            await _dbContext.SaveChangesAsync(cancellationToken);

            return egg.ItemId;
        }
    }
}
