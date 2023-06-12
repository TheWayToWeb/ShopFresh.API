using MediatR;

namespace Items.Application.Products.Bakery.Gingerbread.Commands.DeleteGingerbread
{
    public class DeleteGingerBread : IRequest<Unit>
    {
        public Guid PersonId { get; set; }
        public Guid ItemId { get; set; }
    }
}
