using Items.Application.Interfaces;
using MediatR;
using SelfCottageCheesePatty = Items.Domain.Products.FreshItem.Bread.MakingCottageCheesePatty.CottageCheesePatty;

namespace Items.Application.Products.Bread.CottageCheesePatty.Commands.CreateCottagePatty
{
    public class CreateCottageCheesePattyHandler : IRequestHandler<CreateCottageCheesePatty, Guid>
    {
        private readonly IBreadDbContext _dbContext;

        public CreateCottageCheesePattyHandler(IBreadDbContext dbContext) {
            _dbContext = dbContext;
        }

        public Task<Guid> Handle(CreateCottageCheesePatty request, CancellationToken cancellationToken)
        {
            var cottageCheesePatty = new SelfCottageCheesePatty
            {
                PersonId = request.PersonId,
                ItemId = Guid.NewGuid(),
                ItemName = request.ItemName,
                Maker = null,
                Price = request.Price,
                ImagePath = request.ImagePath,
                MinTemp = request.MinTemp,
                MaxTemp = request.MaxTemp,
                Protein = request.Protein,
                Fat = request.Fat,
                Sugar = request.Sugar,
                Energy = request.Energy,
                CountInPackage = request.CountInPackage,
                ProductExpiryDate = request.ProductExpiryDate,
                Weight = request.Weight,
                CoolingMode = null,
                IsFarmer = false
            };
        }
    }
}
