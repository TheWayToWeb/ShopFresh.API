using Items.Application.Interfaces;
using Items.Domain.Products.FreshItem.FruitsVegetables.Vegetables;
using MediatR;

namespace Items.Application.Products.Vegetables.CreateCauliflower
{
    public class CreateCauliflowerHandler : IRequestHandler<CreateCauliflower, Guid>
    {
        private readonly IVegetableDbContext _dbContext;

        public CreateCauliflowerHandler(IVegetableDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateCauliflower request, CancellationToken cancellationToken)
        {
            var cauliflower = new Cauliflower
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

            await _dbContext.Cauliflowers.AddAsync(cauliflower, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return cauliflower.ItemId;
        }
    }
}
