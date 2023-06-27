using Items.Application.Interfaces;
using MediatR;
using SelfKissel = Items.Domain.Products.FreshItem.Drinks.MakingKissel.Kissel;

namespace Items.Application.Products.Drinks.Kissel.Commands.CreateKissel
{
    public class CreateKisselHandler : IRequestHandler<CreateKissel, Guid>
    {
        private readonly IDrinkDbContext _dbContext;

        public CreateKisselHandler(IDrinkDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateKissel request, CancellationToken cancellationToken)
        {
            var kissel = new SelfKissel
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
                Taste = request.Taste,
                Capacity = request.Capacity,
                IsChilled = request.IsChilled

            };

            await _dbContext.Kissel.AddAsync(kissel, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return kissel.ItemId;
        }
    }
}
