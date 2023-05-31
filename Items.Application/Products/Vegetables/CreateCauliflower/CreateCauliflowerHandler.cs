using Items.Application.Interfaces;
using Items.Domain.Products.Category.SubCategory.FreshGroup.FreshItem.FruitsVegetables.Vegetables;
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

            await _dbContext.Cauliflowers.AddAsync(cauliflower, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return cauliflower.ItemId;
        }
    }
}
