using MediatR;
using Items.Domain.Categories.FreshGroup;

namespace Items.Application.Categories.CreateFreshGroup
{
    public class CreateFreshGroup : IRequest<Guid>
    {
        public string? FreshGroupName { get; set; }
        public List<FreshGroup>? FreshItems { get; set; } = new();
    }
}
