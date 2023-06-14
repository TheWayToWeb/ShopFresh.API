using Items.Application.Interfaces;
using Items.Domain.Products.FreshItem.FruitsVegetables.Fruits;
using MediatR;

namespace Items.Application.Products.Fruits.CreateBlueberry
{
    public class CreateBlueberryHandler : IRequestHandler<CreateBlueberry, Guid>
    {
        private readonly IFruitDbContext _dbContext;

        public CreateBlueberryHandler(IFruitDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateBlueberry request, CancellationToken cancellationToken)
        {
            var blueBerry = new Blueberry
            {
                PersonId = Guid.NewGuid(),
                ItemId = Guid.NewGuid(),
                ItemName = request.ItemName,
                BrandId = Guid.NewGuid(),
                Price = request.Price,
                ImagePath = request.ImagePath,
                MinTemp = request.MinTemp,
                MaxTemp = request.MaxTemp,
                Weight = request.Weight,
                Protein = request.Protein,
                Fat = request.Fat,
                Sugar = request.Sugar,
                Energy = request.Energy,
                CountInPackage = request.CountInPackage,
                BeforeDate = request.BeforeDate,
                ShortName = request.ShortName,
                Grade = request.Grade
            };

            await _dbContext.Blueberries.AddAsync(blueBerry, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return blueBerry.ItemId;
        }
    }
}
