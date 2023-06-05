using MediatR;
using Items.Domain.Categories.FreshGroup;

namespace Items.Application.Categories.CreateFreshGroup
{
    public class CreateFreshGroup : IRequest<Guid>
    {
        public Guid FreshGroupId { get; set; }
        public string? FreshGroupName { get; set; }
        public List<FreshGroup>? FreshItem { get; set; } = new();
    }
}
