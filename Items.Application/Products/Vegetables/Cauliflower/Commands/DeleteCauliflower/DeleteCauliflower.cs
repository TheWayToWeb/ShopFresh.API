using Items.Application.Interfaces;
using MediatR;

namespace Items.Application.Products.Vegetables.Cauliflower.Commands.DeleteCauliflower
{
    public class DeleteCauliflower : IRequest<Unit>
    {
        public Guid PersonId { get; set; }
        public Guid ItemId { get; set; }
    }
}
