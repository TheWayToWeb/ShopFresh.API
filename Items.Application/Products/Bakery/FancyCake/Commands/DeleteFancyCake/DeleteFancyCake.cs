using MediatR;

namespace Items.Application.Products.Bakery.FancyCake.Commands.DeleteFancyCake
{
    public class DeleteFancyCake : IRequest<Unit>
    {
        public Guid PersonId { get; set; }
        public Guid ItemId { get; set; }
    }
}
