using MediatR;

namespace Items.Application.Products.Vegetables.Salad.Commands.DeleteSalad
{
    public class DeleteSalad : IRequest<Unit>
    {
        public Guid PersonId { get; set; }
        public Guid ItemId { get; set; }
    }
}
