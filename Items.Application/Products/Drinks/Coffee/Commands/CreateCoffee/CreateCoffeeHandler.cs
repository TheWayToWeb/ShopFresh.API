using Items.Application.Interfaces;
using Items.Domain.Models.Categories.Drinks.MakingCoffee;
using MediatR;

namespace Items.Application.Products.Drinks.Coffee.Commands.CreateCoffee
{
    public class CreateCoffeeHandler : IRequestHandler<CreateCoffee, Guid>
    {
        private readonly IDrinkDbContext _dbContext;
        private CoffeeMake _selfCoffee;

        public CreateCoffeeHandler(IDrinkDbContext dbContext, CoffeeMake selfCoffee)
        {
            _dbContext = dbContext;
            _selfCoffee = selfCoffee;
        }

        public async Task<Guid> Handle(CreateCoffee request, CancellationToken cancellationToken)
        {

            _selfCoffee = new(
                request.PersonId,
                request.ItemName,
                request.Price,
                request.ImagePath
            );

            var coffee = _selfCoffee.CreateCoffee();

            await _dbContext.Coffee.AddAsync(coffee, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return coffee.ItemId;
        }
    }
}
