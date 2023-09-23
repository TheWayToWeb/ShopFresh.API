using MediatR;

namespace Items.Application.ItemsFood.Commands.DeleteItemFood
{
    public class DeleteItemFoodRequest : IRequest<Unit>
    {
        public Guid ItemId { get; set; }
    }
}
