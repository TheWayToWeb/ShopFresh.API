using Items.Application.Interfaces;
using SelfSquash = Items.Domain.Models.Categories.Vegetables.Squash;
using MediatR;

namespace Items.Application.Products.Vegetables.Squash.Commands.CreateSquash
{
    public class CreateSquashHandler : IRequestHandler<CreateSquash, Guid>
    {
        private readonly IVegetableDbContext _dbContext;

        public CreateSquashHandler(IVegetableDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateSquash request, CancellationToken cancellationToken)
        {
            var squash = new SelfSquash
            {
                PersonId = request.PersonId,
                ItemId = Guid.NewGuid(),
                ItemName = request.ItemName,
                Maker = null,
                Price = request.Price,
                ImagePath = request.ImagePath,
                Maker = null,
                MinTemp = request.MinTemp,
                MaxTemp = request.MaxTemp,
                Protein = request.Protein,
                Fat = request.Fat,
                Energy = request.Energy,
                CountInPackage = request.CountInPackage,
                ProductExpiryDate = request.ProductExpiryDate,
                Weight = request.Weight,
                CoolingMode = null,
                IsFarmer = false,
                Sort = request.Sort,
                IsSlicingShape = false
            };

            await _dbContext.Squashes.AddAsync(squash, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return squash.ItemId;
        }
    }
}
