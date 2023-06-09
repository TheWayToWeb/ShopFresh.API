using Items.Application.Interfaces;
using MediatR;
using System.Runtime.ConstrainedExecution;
using SelfCoffee = Items.Domain.Products.FreshItem.Drinks.Coffee;

namespace Items.Application.Products.Drinks.Coffee.Commands.CreateCoffee
{
    public class CreateCoffeeHandler : IRequestHandler<CreateCoffee, Guid>
    {
        private readonly IDrinkDbContext _dbContext;

        public CreateCoffeeHandler(IDrinkDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateCoffee request, CancellationToken cancellationToken)
        {
            var coffee = new SelfCoffee
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
               TypeCoffee = request.TypeOfCoffee,
               KindOfCofee = request.KindOfCoffee,
               Consistency = request.Consistency,
               Composition = request.Composition,
               TasteIntensity = request.TasteIntensity,
               IsCoffeinFree = request.IsCoffeinFree
            };

            await _dbContext.Coffee.AddAsync(coffee, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return coffee.ItemId;
        }
    }
}
