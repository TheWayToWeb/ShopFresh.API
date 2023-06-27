using Items.Application.Interfaces;
using MediatR;
using SelfSoyMilk = Items.Domain.Products.FreshItem.Drinks.MakingSoyMilk.SoyMilk;

namespace Items.Application.Products.Drinks.SoyMilk.Commands.CreateSoyMilk
{
    public class CreateSoyMilkHandler : IRequestHandler<CreateSoyMilk, Guid>
    {
        private readonly IDrinkDbContext _dbContext;

        public CreateSoyMilkHandler(IDrinkDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateSoyMilk request, CancellationToken cancellationToken)
        {
            var soyMilk = new SelfSoyMilk
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
                IsChilled = request.IsChilled,
                KindOfMilk = request.KindOfMilk
            };

            await _dbContext.SoyMilk.AddAsync(soyMilk, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return soyMilk.ItemId;
        }
    }
}
