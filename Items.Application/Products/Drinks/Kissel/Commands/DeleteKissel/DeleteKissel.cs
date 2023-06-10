using MediatR;

namespace Items.Application.Products.Drinks.Kissel.Commands.DeleteKissel
{
    public class DeleteKissel : IRequest<Unit>
    {
        public Guid PersonId { get; set; }
        public Guid ItemId { get; set; }
    }
}
