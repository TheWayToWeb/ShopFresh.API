using MediatR;

namespace Items.Application.Products.Drinks.Lemonade.Commands.DeleteLemonade
{
    public class DeleteLemonade : IRequest<Unit>
    {
        public Guid PersonId { get; set; }
        public Guid Itemid { get; set; }
    }
}
