using MediatR;

namespace Items.Application.Products.Vegetables.Potato.Commands.DeletePotato
{
    public class DeletePotato : IRequest<Unit>
    {
        public Guid PersonId { get; set; }
        public Guid ItemId { get; set; }
    }
}
