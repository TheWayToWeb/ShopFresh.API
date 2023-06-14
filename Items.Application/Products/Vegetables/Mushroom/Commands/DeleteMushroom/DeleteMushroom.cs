using MediatR;

namespace Items.Application.Products.Vegetables.Mushroom.Commands.DeleteMushroom
{
    public class DeleteMushroom : IRequest<Unit>
    {
        public Guid PersonId { get; set; }
        public Guid ItemId { get; set; }
    }
}
