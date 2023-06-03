using Items.Application.Interfaces;
using Items.Domain.Products.Category.SubCategory.FreshGroup.FreshItem.MilkProducts;
using MediatR;

namespace Items.Application.Products.ProductMilk.CreateDrinkingMilk
{
    public class CreateDrinkMilkHandler : IRequestHandler<CreateDrinkMilk, Guid>
    {
        private readonly IMilkDbContext _dbContext;

        public CreateDrinkMilkHandler(IMilkDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateDrinkMilk request, CancellationToken cancellationToken)
        {
            var drinkMilk = new DrinkMilk
            {
                PersonId = Guid.NewGuid(),
                ItemId = Guid.NewGuid(),
                ItemName = request.ItemName,
                Brand = request.Brand,
                Price = request.Price,
                ImagePath = request.ImagePath,
                MinTemp = request.MinTemp,
                MaxTemp = request.MaxTemp,
                Capacities = request.Capacities,
                Weight = null,
                Protein = request.Protein,
                Fat = request.Fat,
                Sugar = request.Sugar,
                Energy = request.Energy,
                CountInPackage = request.CountInPackage,
                BeforeDate = request.BeforeDate,
                IsLactoseFree = request.IsLactoseFree,
                IsFarmer = request.IsFarmer,
                IsVegan = request.IsVegan,
                Taste = request.Taste,
                FatContent = request.FatContent,
                IsBestseller = request.IsBestseller
            };

            await _dbContext.DrinkMilk.AddAsync(drinkMilk, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return drinkMilk.ItemId;
        }
    }
}
