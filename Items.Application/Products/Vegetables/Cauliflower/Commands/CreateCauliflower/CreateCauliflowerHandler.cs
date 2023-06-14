using Items.Application.Interfaces;
using Items.Domain.Products.FreshItem.FruitsVegetables.Vegetables;
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
            var cauliflower = new Cauliflower
            {
                PersonId = Guid.NewGuid(),
                ItemId = Guid.NewGuid(),
                ItemName = request.ItemName,
                Price = request.Price,
                ImagePath = request.ImagePath,
                MinTemp = request.MinTemp,
                MaxTemp = request.MaxTemp,
                Protein = request.Protein,
                Energy = request.Energy,
                CountInPackage = request.CountInPackage,
                ProductExpiryDate = request.ProductExpiryDate,
                Weight = request.Weight,
                Sort = request.Sort,
                CoolingMode = request.CoolingMode
            };

            await _dbContext.Cauliflowers.AddAsync(cauliflower, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return cauliflower.ItemId;
        }
    }
}
