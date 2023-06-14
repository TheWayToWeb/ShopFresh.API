using Items.Application.Interfaces;
using MediatR;
using SelfTomato = Items.Domain.Products.FreshItem.FruitsVegetables.Vegetables.Tomato;

namespace Items.Application.Products.Vegetables.Tomato.Commands.CreateTomato
{
    public class CreateTomatoHandler : IRequestHandler<CreateTomato, Guid>
    {
        private readonly IVegetableDbContext _dbContext;

        public CreateTomatoHandler(IVegetableDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateTomato request, CancellationToken cancellationToken)
        {
            var tomato = new SelfTomato
            {
                PersonId = Guid.NewGuid(),
                ItemId = Guid.NewGuid(),
                ItemName = request.ItemName,
                Price = request.Price,
                ImagePath = request.ImagePath,
                MinTemp = request.MinTemp,
                MaxTemp = request.MaxTemp,
                Fat = request.Fat,
                Sugar = request.Sugar,
                Energy = request.Energy,
                CountInPackage = request.CountInPackage,
                ProductExpiryDate = request.ProductExpiryDate,
                Weight = request.Weight,
                Sort = request.Sort
            };

            await _dbContext.Tomatoes.AddAsync(tomato, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return tomato.ItemId;
        }
    }
}
