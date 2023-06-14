using MediatR;

namespace Items.Application.Products.Vegetables.VegetableMix.DeleteVegetableMix
{
    public class DeleteVegetableMix : IRequest<Unit>
    {
        public Guid PersonId { get; set; }
        public Guid ItemId { get; set; }
    }
}
