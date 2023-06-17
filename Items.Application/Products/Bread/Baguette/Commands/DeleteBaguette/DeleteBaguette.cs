using MediatR;

namespace Items.Application.Products.Bread.Baguette.Commands.DeleteBaguette
{
    public class DeleteBaguette : IRequest<Unit>
    {
        public Guid PersonId { get; set; }
        public Guid ItemId { get; set; }
    }
}
