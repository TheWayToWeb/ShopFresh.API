using Items.Application.Interfaces;
using MediatR;
using SelfMushroom = Items.Domain.Entities.Categories.Vegetables.ConcreteMushroom.Mushroom.Mushroom;

namespace Items.Application.Products.Vegetables.Mushroom.Commands.CreateMushroom
{
    public class CreateMushroomHandler : IRequestHandler<CreateMushroom, Guid>
    {
        private readonly IVegetableDbContext _dbContext;

        public CreateMushroomHandler(IVegetableDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateMushroom request, CancellationToken cancellationToken)
        {
            var mushroom = new SelfMushroom
            {
                PersonId = request.PersonId,
                ItemId = Guid.NewGuid(),
                ItemName = request.ItemName,
                Price = request.Price,
                ImagePath = request.ImagePath,
                Maker = null,
                MinTemp = request.MinTemp,
                MaxTemp = request.MaxTemp,
                Protein = request.Protein,
                Fat = request.Fat,
                Sugar = 0,
                Energy = request.Energy,
                CountInPackage = request.CountInPackage,
                ProductExpiryDate = request.ProductExpiryDate,
                Weight = request.Weight,
                CoolingMode = request.CoolingMode,
                IsFarmer = false,
                Sort = request.Sort,
                IsSlicingShape = request.IsSlicingShape
            };

            await _dbContext.Mushrooms.AddAsync(mushroom, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return mushroom.ItemId;
        }
    }
}
