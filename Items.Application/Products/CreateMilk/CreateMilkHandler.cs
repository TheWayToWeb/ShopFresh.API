using Items.Application.Interfaces;
using Items.Domain.Products.Category.SubCategory.ItemCategory.Items.Dairy_products_and_eggs;
using MediatR;

namespace Items.Application.Products.CreateMilk
{
    public class CreateMilkHandler : IRequestHandler<CreateMilk, Guid>
    {
        private readonly IFruitDbContext _dbContext;

        public CreateMilkHandler(IFruitDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateMilk request, CancellationToken cancellationToken)
        {
            var milk = new Milk
            {
                PersonId = Guid.NewGuid(),
                ItemId = Guid.NewGuid(),
                ItemName = request.ItemName,
                Brand = request.Brand,
                Price = request.Price,
                ImagePath = request.ImagePath,
                Maker = request.Maker,
                FatContent = request.FatContent,
                Capacity = request.Capacity,
                Raw = request.Raw,
                Kind = request.Kind,
                IsFarmer = request.IsFarmer
            };

            await _dbContext.SaveChangesAsync(cancellationToken);

            return milk.ItemId;
        }
    }
}
