using MediatR;

namespace Items.Application.Products.Drinks.TeaDrink.Commands.DeleteTeaDrink
{
    public class DeleteTeaDrink : IRequest<Unit>
    {
        public Guid PersonId { get; set; }
        public Guid ItemId { get; set; }

    }
}
