using Items.Application.Interfaces;
using SelfBeet = Items.Domain.Products.FreshItem.FruitsVegetables.Vegetables.Beet;
using MediatR;

namespace Items.Application.Products.FruisVegetables.Vegetables.Beet.Commands.CreateBeet
{
    public class CreateBeetHandler : IRequestHandler<CreateBeet, Guid>
    {
        private readonly IVegetableDbContext _dbContext;

        public CreateBeetHandler(IVegetableDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateBeet request, CancellationToken cancellationToken)
        {
            var beet = new SelfBeet
            {
                PersonId = Guid.NewGuid(),
                ItemId = Guid.NewGuid(),
                ItemName = request.ItemName,
                BrandId = Guid.NewGuid(),
                Price = request.Price,
                ImagePath = request.ImagePath,
                MinTemp = request.MinTemp,
                MaxTemp = request.MaxTemp,
                Protein = request.Protein,
                Fat = request.Fat,
                Sugar = request.Sugar,
                Energy = request.Energy,
                CountInPackage = request.CountInPackage,
                BeforeDate = request.BeforeDate,
                Weight = request.Weight,
                CoolingMode = request.CoolingMode,
                ShortName = request.ShortName
            };

            await _dbContext.Beets.AddAsync(beet, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return beet.ItemId;
        }
    }
}
