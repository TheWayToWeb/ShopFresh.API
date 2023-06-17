using MediatR;

namespace Items.Application.Products.Vegetables.Broccoli.DeleteBroccoli
{
    public class DeleteBroccoli : IRequest<Unit>
    {
        public Guid PersonId { get; set; }
        public Guid ItemId { get; set; }
    }
}
