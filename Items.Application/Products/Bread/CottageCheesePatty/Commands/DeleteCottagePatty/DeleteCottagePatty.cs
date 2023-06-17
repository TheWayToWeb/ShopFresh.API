using MediatR;

namespace Items.Application.Products.Bread.CottageCheesePatty.Commands.DeleteCottagePatty
{
    public class DeleteCottagePatty : IRequest<Unit>
    {
        public Guid PersonId { get; set; }
        public Guid ItemId { get; set; }
    }
}
