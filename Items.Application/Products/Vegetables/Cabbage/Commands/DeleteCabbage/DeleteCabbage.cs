using MediatR;

namespace Items.Application.Products.Vegetables.Cabbage.Commands.DeleteCabbage
{
    public class DeleteCabbage : IRequest<Unit>
    {
        public Guid PersonId { get; set; }
        public Guid ItemId { get; set; }
    }
}
