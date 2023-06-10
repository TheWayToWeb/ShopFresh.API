using MediatR;

namespace Items.Application.Products.Drinks.FruitDrink.Commands.DeleteFruitDrink
{
    public class DeleteFruitDrink : IRequest<Unit>
    {
        public Guid PersonId { get; set; }
        public Guid ItemId { get; set; }
    }
}
