using Items.Application.Interfaces;
using Items.Domain.Products.Category.SubCategory.FreshGroup.FreshItem.MilkProducts;
using MediatR;

namespace Items.Application.Products.ProductMilk.CreateYogurt
{
    public class CreateYogurtHandler : IRequestHandler<CreateYogurt, Guid>
    {
        private readonly IMilkDbContext _dbContext;

        public CreateYogurtHandler(IMilkDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateYogurt request, CancellationToken cancellationToken)
        {
            var yogurt = new Yogurt
            {
                PersonId = Guid.NewGuid(),
                ItemId = Guid.NewGuid(),
                ItemName = request.ItemName,
                Brand = request.Brand,
                Price = request.Price,
                ImagePath = request.ImagePath,
                MinTemp = request.MinTemp,
                MaxTemp = request.MaxTemp,
                Weight = request.Weight,
                Capacities = request.Capacities,
                Protein = request.Protein,
                Fat = request.Fat,
                Sugar = request.Sugar,
                Energy = request.Energy,
                CountInPackage = request.CountInPackage,
                BeforeDate = request.BeforeDate,
                IsLactoseFree = request.IsLactoseFree,
                IsFarmer = request.IsFarmer,
                IsVegan = request.IsVegan,
                IsBestseller = request.IsBestseller,
                Tastes = request.Tastes,
                FatContent = request.FatContent
            };

            await _dbContext.Yogurts.AddAsync(yogurt, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return yogurt.ItemId;
        }
    }
}

