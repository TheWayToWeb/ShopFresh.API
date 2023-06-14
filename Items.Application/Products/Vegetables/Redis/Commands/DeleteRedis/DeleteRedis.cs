using MediatR;

namespace Items.Application.Products.Vegetables.Redis.Commands.DeleteRedis
{
    public class DeleteRedis : IRequest<Unit>
    {
        public Guid PersonId { get; set; }
        public Guid ItemId { get; set; }
    }
}
