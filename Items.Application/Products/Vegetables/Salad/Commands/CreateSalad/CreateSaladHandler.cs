using Items.Application.Interfaces;
using SelfSalad = Items.Domain.Entities.Categories.Vegetables.ConcreteSalad.Salad.Salad;
using MediatR;

namespace Items.Application.Products.Vegetables.Salad.Commands.CreateSalad
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
            var salad = new SelfSalad
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
                Fat = 0,
                Sugar = 0,
                Energy = request.Energy,
                CountInPackage = request.CountInPackage,
                ProductExpiryDate = request.ProductExpiryDate,
                Weight = null,
                CoolingMode = request.CoolingMode,
                IsFarmer = false,
                Sort = request.Sort,
                IsSlicingShape = request.IsSlicingShape
            };

            await _dbContext.Salads.AddAsync(salad, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return salad.ItemId;
        }
    }
}
