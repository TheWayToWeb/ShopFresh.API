using Items.Application.Interfaces;
using Items.Domain.Products.Category.SubCategory.FreshGroup.FreshItem.FruitsVegetables.Vegetables;
using MediatR;

namespace Items.Application.Products.Vegetables.CreateSalad
{
    public class CreateSaladHandler : IRequestHandler<CreateSalad, Guid>
    {
        private readonly IVegetableDbContext _dbContext;

        public CreateSaladHandler(IVegetableDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateSalad request, CancellationToken cancellationToken)
        {
            var salad = new Salad
            {
                PersonId = Guid.NewGuid(),
                ItemId = Guid.NewGuid(),
                ItemName = request.ItemName,
                Brand = request.Brand,
                Price = request.Price,
                ImagePath = request.ImagePath,
                Maker = request.Maker,
                Storage = request.Storage,
                MinTemp = request.MinTemp,
                MaxTemp = request.MaxTemp,
                CoolingMode = request.CoolingMode,
                Shape = request.Shape,
                Contain = request.Contain,
                Weight = request.Weight,
                Protein = request.Protein,
                Fat = request.Fat,
                Sugar = request.Sugar,
                Energy = request.Energy,
                CountInPackage = request.CountInPackage,
                BeforeDate = request.BeforeDate,
                ShortName = request.ShortName,
                Description = request.Description,
                Package = request.Package,
                Grade = request.Grade
            };

            await _dbContext.Salads.AddAsync(salad, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return salad.ItemId;
        }
    }
}
