using MediatR;

namespace Items.Application.Products.Vegetables.Cabbage.Commands.UpdateCabbage
{
    public class UpdateCabbage : IRequest<Unit>
    {
        public Guid PersonId { get; set; }
        public Guid ItemId { get; set; }

    }
}
