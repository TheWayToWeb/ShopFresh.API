using Items.Application.Interfaces;
using Items.Domain.Products.FreshItem.MilkProducts;
using MediatR;

namespace Items.Application.Products.ProductMilk.CreateGlazedCheese
{
    public class CreateGlazedCheeseHandler : IRequestHandler<CreateGalzedCheese, Guid>
    {
        private readonly IMilkDbContext _dbContext;

        public CreateGlazedCheeseHandler(IMilkDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateGalzedCheese request, CancellationToken cancellationToken)
        {
            var glazedCheese = new GlazedCheese
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
                IsBestseller = request.IsBestseller,
                Taste = request.Taste,
                FatContent = request.FatContent,
                IsHalal = request.IsHalal
            };

            await _dbContext.GlazedCheeses.AddAsync(glazedCheese, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return glazedCheese.ItemId;
        }
    }
}
