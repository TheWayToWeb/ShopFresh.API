using MediatR;

namespace Items.Application.Products.Vegetables.Tomato.Commands.DeleteTomato
{
    public class DeleteTomato : IRequest<Unit>
    {
        public Guid PersonId { get; set; }
        public Guid ItemId { get; set; }
    }
}
