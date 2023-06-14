using MediatR;

namespace Items.Application.Products.Vegetables.Carrot.Commands.DeleteCarrot
{
    public class DeleteCarrot : IRequest<Unit>
    {
        public Guid PersonId { get; set; }
        public Guid ItemId { get; set; }
    }
}
