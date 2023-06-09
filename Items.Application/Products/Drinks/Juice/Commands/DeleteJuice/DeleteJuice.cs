using MediatR;

namespace Items.Application.Products.Drinks.Juice.Commands.DeleteJuice
{
    public class DeleteJuice : IRequest<Unit>
    {
        public Guid PersonId { get; set; }
        public Guid ItemId { get; set; }
    }
}
