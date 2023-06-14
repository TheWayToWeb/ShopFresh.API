using MediatR;

namespace Items.Application.Products.Vegetables.Squash.Commands.DeleteSquash
{
    public class DeleteSquash : IRequest<Unit>
    {
        public Guid PersonId { get; set; }
        public Guid ItemId { get; set; }
    }
}
