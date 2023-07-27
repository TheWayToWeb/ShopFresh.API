using Items.Application.Interfaces;
using SelfBeet = Items.Domain.Entities.Categories.Vegetables.ConcreteBeet.Beet.Beet;
using MediatR;

namespace Items.Application.Products.Vegetables.Beet.Commands.CreateBeet
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
                PersonId = request.PersonId,
                ItemId = Guid.NewGuid(),
                ItemName = request.ItemName,
                Price = request.Price,
                ImagePath = request.ImagePath,
                Maker = null,
                MinTemp = request.MinTemp,
                MaxTemp = request.MaxTemp,
                Protein = request.Protein,
                Fat = 0,
                Sugar = 0,
                Energy = request.Energy,
                CountInPackage = request.CountInPackage,
                ProductExpiryDate = request.ProductExpiryDate,
                Weight = request.Weight,
                CoolingMode = request.CoolingMode,
                IsFarmer = false,
                Sort = request.Sort,
                IsSlicingShape = request.IsSlicingShape
            };

            await _dbContext.Beets.AddAsync(beet, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return beet.ItemId;
        }
    }
}
