using MediatR;

namespace Items.Application.ItemsFood.Queries.ItemFoodDetails
{
    public class ItemFoodDetailsQuery : IRequest<ItemFoodDetailsVm>
    {
        public Guid Id { get; set; }

    }
}
