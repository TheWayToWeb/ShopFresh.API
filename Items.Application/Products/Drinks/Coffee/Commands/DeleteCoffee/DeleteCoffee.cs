using MediatR;

namespace Items.Application.Products.Drinks.Coffee.Commands.DeleteCoffee
{
    public class DeleteCoffee : IRequest<Unit>
    {
        public Guid PersonId { get; set; }
        public Guid ItemId { get; set; }
    }
}
