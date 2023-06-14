using MediatR;

namespace Items.Application.Products.Vegetables.SaladMix.Commands.DeleteSaladMix
{
    public class DeleteSaladMix : IRequest<Unit>
    {
        public Guid PersonId { get; set; }
        public Guid ItemId { get; set; }
    }
}
