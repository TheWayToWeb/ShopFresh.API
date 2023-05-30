using MediatR;
using Items.Domain.Products.Category.SubCategory.FreshGroup;

namespace Items.Application.Products.CreateFreshGroup
{
    public class CreateFreshGroup : IRequest<Guid>
    {
        public Guid FreshGroupId { get; set; }
        public string? FreshGroupName { get; set; }
        public List<FreshGroup>? FreshItem { get; set; } = new();
    }
}
