using Items.Application.Interfaces;
using Items.Domain.Products.Category.SubCategory.FreshGroup.FreshItem.Cheese;
using MediatR;

namespace Items.Application.Products.CreateCheese
{
    public class CreateCheeseHandler : IRequestHandler<CreateCheese, Guid>
    {
        private readonly IFruitDbContext _dbContext;

        public CreateCheeseHandler(IFruitDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateCheese request, CancellationToken cancellationToken)
        {
            var cheese = new Cheese
            {
                PersonId = Guid.NewGuid(),
                ItemId = Guid.NewGuid(),
                ItemName = request.ItemName,
                Brand = request.Brand,
                Price = request.Price,
                ImagePath = request.ImagePath,
                Maker = request.Maker,
                Kind = request.Kind,
                Type = request.Type,
                Shape = request.Shape,
                Raw = request.Raw,
                IsFarmer = request.IsFarmer
            };

            await _dbContext.SaveChangesAsync(cancellationToken);

            return cheese.ItemId;
        }
    }
}
