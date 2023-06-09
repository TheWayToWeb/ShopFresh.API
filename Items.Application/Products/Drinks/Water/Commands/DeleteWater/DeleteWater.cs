using MediatR;

namespace Items.Application.Products.Drinks.Water.Commands.DeleteWater
{
    public class DeleteWater : IRequest<Unit>
    {
        public Guid PersonId { get; set; }
        public Guid ItemId { get; set; }
    }
}
