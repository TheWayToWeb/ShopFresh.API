using MediatR;

namespace Items.Application.Products.Eggs.Commands.DeleteEggs
{
    public class DeleteEgg : IRequest<Unit>
    {
        public Guid PersonId { get; set; }
        public Guid ItemId { get; set; }
    }
}
