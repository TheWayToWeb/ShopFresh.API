using Items.Application.Interfaces;
using MediatR;
using SelfLemonade = Items.Domain.Products.FreshItem.Drinks.MakingLemonade.Lemonade;

namespace Items.Application.Products.Drinks.Lemonade.Commands.CreateLemonade
{
    public class CreateLemonadeHandler : IRequestHandler<CreateLemonade, Guid>
    {
        private readonly IDrinkDbContext _dbContext;

        public CreateLemonadeHandler(IDrinkDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateLemonade request, CancellationToken cancellationToken)
        {
            var lemonade = new SelfLemonade
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
                IsSparkling = request.IsSparkling
            };

            await _dbContext.Lemonades.AddAsync(lemonade, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return lemonade.ItemId;
        }
    }
}
