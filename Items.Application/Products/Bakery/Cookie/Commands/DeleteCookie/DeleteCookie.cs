using MediatR;

namespace Items.Application.Products.Bakery.Cookie.Commands.DeleteCookie
{
    public class DeleteCookie : IRequest<Unit>
    {
        public Guid PersonId { get; set; }
        public Guid ItemId { get; set; }
    }
}
