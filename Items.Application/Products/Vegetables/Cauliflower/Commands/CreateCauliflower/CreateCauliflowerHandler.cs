using Items.Application.Interfaces;
using SelfCauliflower = Items.Domain.Products.FreshItem.FruitsVegetables.Vegetables.Cauliflower;
using MediatR;

namespace Items.Application.Products.Vegetables.Cauliflower.Commands.CreateCauliflower
{
    public class CreateCauliflowerHandler : IRequestHandler<CreateCauliflower, Guid>
    {
        private readonly IVegetableDbContext _dbContext;

        public CreateCauliflowerHandler(IVegetableDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateCauliflower request, CancellationToken cancellationToken)
        {
            var cauliflower = new SelfCauliflower
            {
                PersonId = Guid.NewGuid(),
                ItemId = Guid.NewGuid(),
                ItemName = request.ItemName,
                Price = request.Price,
                ImagePath = request.ImagePath,
                MinTemp = request.MinTemp,
                MaxTemp = request.MaxTemp,
                Protein = request.Protein,
                Fat = 0,
                Sugar = 0,
                Energy = request.Energy,
                CountInPackage = request.CountInPackage,
                ProductExpiryDate = request.ProductExpiryDate,
                Weight = request.Weight,
                CoolingMode = request.CoolingMode,
                IsFarmer = false,
                Sort = request.Sort,
                IsSlicingShape = false
            };

            await _dbContext.Cauliflowers.AddAsync(cauliflower, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return cauliflower.ItemId;
        }
    }
}
