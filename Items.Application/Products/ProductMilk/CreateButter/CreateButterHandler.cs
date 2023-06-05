using Items.Application.Interfaces;
using Items.Domain.Products.FreshItem.MilkProducts;
using MediatR;

namespace Items.Application.Products.ProductMilk.CreateButter
{
    public class CreateButterHandler : IRequestHandler<CreateButter, Guid>
    {
        private readonly IMilkDbContext _dbContext;

        public CreateButterHandler(IMilkDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateButter request, CancellationToken cancellationToken)
        {
            var butter = new Butter
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
                IsLactoseFree = request.IsLactoseFree,
                IsFarmer = request.IsFarmer,
                IsVegan = request.IsVegan,
                IsBestseller = request.IsBestseller
            };

            await _dbContext.Butters.AddAsync(butter, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return butter.ItemId;
        }
    }
}
