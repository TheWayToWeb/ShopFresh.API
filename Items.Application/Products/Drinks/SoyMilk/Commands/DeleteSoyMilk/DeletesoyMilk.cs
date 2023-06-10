using MediatR;

namespace Items.Application.Products.Drinks.SoyMilk.Commands.DeleteSoyMilk
{
    public class DeleteSoyMilk : IRequest<Unit>
    {
        public Guid PersonId { get; set; }
        public Guid ItemId { get; set; }
    }
}
