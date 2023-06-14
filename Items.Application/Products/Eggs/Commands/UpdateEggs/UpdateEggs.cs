using MediatR;

namespace Items.Application.Products.Eggs.Commands.UpdateEggs
{
    public class UpdateEggs : IRequest<Unit>
    {
        public Guid PersonId { get; set; }
        public Guid ItemId { get; set; }
        public string? ItemName { get; set; }

    }
}
