using Items.Application.Interfaces;
using Items.Domain.Products.Category.SubCategory.FreshGroup.FreshItem.MilkProducts;
using MediatR;

namespace Items.Application.Products.ProductMilk.CreateCream
{
    public class CreateCreamHandler : IRequestHandler<CreateCream, Guid>
    {
        private readonly IMilkDbContext _dbContext;

        public CreateCreamHandler(IMilkDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateCream request, CancellationToken cancellationToken)
        {
            var cream = new Cream
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
                KindCream = request.KindCream,
                Fats = request.Fats
            };

            await _dbContext.Creams.AddAsync(cream, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return cream.ItemId;
        }
    }
}
