using Items.Application.Interfaces;
using Items.Domain.Products.FreshItem.FruitsVegetables.Vegetables;
using MediatR;

namespace Items.Application.Products.FruisVegetables.Vegetables.CreateSalad
{
    public class CreateSaladHandler : IRequestHandler<CreateSalad, Guid>
    {
        private readonly IVegetableDbContext _dbContext;

        public CreateSaladHandler(IVegetableDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateSalad request, CancellationToken cancellationToken)
        {
            var salad = new Salad
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

            await _dbContext.Salads.AddAsync(salad, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return salad.ItemId;
        }
    }
}
