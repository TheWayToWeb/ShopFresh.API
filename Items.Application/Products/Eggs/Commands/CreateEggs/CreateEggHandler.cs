using Items.Application.Interfaces;
using Items.Domain.Products.FreshItem.Eggs;
using MediatR;

namespace Items.Application.Products.Eggs.Commands.CreateEggs
{
    public class CreateEggHandler : IRequestHandler<CreateEgg, Guid>
    {
        private readonly IMilkDbContext _dbContext;

        public CreateEggHandler(IMilkDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateEgg request, CancellationToken cancellationToken)
        {
            var egg = new Egg
            {
                PersonId = Guid.NewGuid(),
                ItemId = Guid.NewGuid(),
                ItemName = request.ItemName,
                BrandId = Guid.NewGuid(),
                Price = request.Price,
                ImagePath = request.ImagePath,
                MinTemp = request.MinTemp,
                MaxTemp = request.Maxtemp,
                Shape = request.Shape,
                Weight = request.Weight,
                Protein = request.Protein,
                Fat = request.Fat,
                Sugar = request.Sugar,
                Energy = request.Energy,
                CountInPackage = request.CountInPackage,
                BeforeDate = request.BeforeDate,
                Kind = request.Kind,
                Sort = request.Sort,
                IsFarmer = request.IsFarmer
            };

            await _dbContext.Eggs.AddAsync(egg, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return egg.ItemId;
        }
    }
}
