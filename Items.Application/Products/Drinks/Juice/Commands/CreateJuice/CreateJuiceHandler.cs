using Items.Application.Interfaces;
using MediatR;
using SelfJuice =  Items.Domain.Products.FreshItem.Drinks.Juice;

namespace Items.Application.Products.Drinks.Juice.Commands.CreateJuice
{
    public class CreateJuiceHandler : IRequestHandler<CreateJuice, Guid>
    {
        private readonly IDrinkDbContext _dbContext;

        public CreateJuiceHandler(IDrinkDbContext dbContext) {
            _dbContext = dbContext;
        }

        public Task<Guid> Handle(CreateJuice request, CancellationToken cancellationToken)
        {
            var juice = new SelfJuice
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
                Capacity = request.Capacity,
                Taste = request.Taste,
                IsChilled = request.IsChilled
            };
        }
    }
}
