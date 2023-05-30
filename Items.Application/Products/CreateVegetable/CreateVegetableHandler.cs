using Items.Application.Interfaces;
using Items.Domain.Products.Category.SubCategory.ItemCategory.Items.Vegetables;
using MediatR;

namespace Items.Application.Products.CreateVegetable
{
    public class CreateVegetableHandler : IRequestHandler<CreateVegetable, Guid>
    {
        private readonly IFruitDbContext _dbContext;

        public CreateVegetableHandler(IFruitDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateVegetable request, CancellationToken cancellationToken)
        {
            var vegetable = new Vegetable
            {
                PersonId = Guid.NewGuid(),
                ItemId = Guid.NewGuid(),
                ItemName = request.ItemName,
                Brand = request.Brand,
                Price = request.Price,
                ImagePath = request.ImagePath,
                Maker = request.Maker,
                Kind = request.Kind,
                Weight = request.Weight,
                Shape = request.Shape,
                BeforeDate = request.BeforeDate,
                Package = request.Package,
                CoolingMode = request.CoolingMode,
                IsVitamin = request.IsVitamin
            };

            await _dbContext.SaveChangesAsync(cancellationToken);

            return vegetable.ItemId;
        }
    }
}
