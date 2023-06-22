using MediatR;

namespace Items.Application.Products.Bakery.Cookie.Commands.CreateCookie
{
    public class CreateCookieRequest : IRequest<Guid>
    {
        public Guid PersonId { get; set; }
        public string? ItemName { get; set; }
        public int Price { get; set; }
        public string? ImagePath { get; set; }
    }
}
