using Items.Application.Interfaces;
using MediatR;
using SelfTeaDrink = Items.Domain.Products.FreshItem.Drinks.TeaDrink;

namespace Items.Application.Products.Drinks.TeaDrink.Commands.CreateTeaDrink
{
    public class CreateTeaDrinkHandler : IRequestHandler<CreateTeaDrink, Guid>
    {
        private readonly IDrinkDbContext _dbContext;

        public CreateTeaDrinkHandler(IDrinkDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateTeaDrink request, CancellationToken cancellationToken)
        {
            var teaDrink = new SelfTeaDrink
            {
                PersonId = Guid.NewGuid(),
                ItemId = Guid.NewGuid(),
                ItemName = request.ItemName,
                BrandId = Guid.NewGuid(),
                Price = request.Price,
                ImagePath = request.ImagePath,
                MinTemp = request.MinTemp,
                MaxTemp = request.MaxTemp,
                Protein = request.Protein,
                Fat = request.Fat,
                Sugar = request.Sugar,
                Energy = request.Energy,
                CountInPackage = request.CountInPackage,
                BeforeDate = request.BeforeDate,
                Capacity = request.Capacity,
                Taste = request.Taste,
                IsChilled = request.IsChilled,
                Sort = request.Sort,
                KindOfTea = request.KindOfTea
            };

            await _dbContext.TeaDrinks.AddAsync(teaDrink, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return teaDrink.ItemId;
        }
    }
}
