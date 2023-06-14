using MediatR;

namespace Items.Application.Products.Vegetables.Beans.Commands.DeleteBeans
{
    public class DeleteBean : IRequest<Unit>
    {
        public Guid PersonId { get; set; }
        public Guid Itemid { get; set; }
    }
}
