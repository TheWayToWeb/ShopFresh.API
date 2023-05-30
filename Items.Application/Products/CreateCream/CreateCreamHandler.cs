using Items.Application.Interfaces;
using MediatR;

namespace Items.Application.Products.CreateCream
{
    public class CreateCreamHandler : IRequestHandler<CreateCream, Guid>
    {
        private readonly IFruitDbContext _dbContext;

        public CreateCreamHandler(IFruitDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateCream request, CancellationToken cancellationToken)
        {
            var createCream = new CreateCream
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

            return createCream.ItemId;
        }
    }
}
