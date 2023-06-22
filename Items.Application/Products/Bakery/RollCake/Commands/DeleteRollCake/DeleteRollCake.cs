using MediatR;

namespace Items.Application.Products.Bakery.RollCake.Commands.DeleteRollCake
{
    public class DeleteRollCake : IRequest<Unit>
    {
        public Guid PersonId { get; set; }
        public Guid ItemId { get; set; }
    }
}
