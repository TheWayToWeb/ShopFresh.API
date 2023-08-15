using Items.Application.Interfaces;
using MediatR;
using SelfTeaDrink = Items.Domain.Components.Entities.Categories.Drinks.MakingTea.MakingDrinkingTea.TeaDrink;

namespace Items.Application.Products.Drinks.TeaDrink.Commands.CreateTeaDrink
{
    public class CreateDrinkingTeaHandler : IRequestHandler<CreateDrinkingTea, Guid>
    {
        private readonly IDrinkDbContext _dbContext;

        public CreateDrinkingTeaHandler(IDrinkDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateDrinkingTea request, CancellationToken cancellationToken)
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
