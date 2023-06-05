using MediatR;
using Items.Domain.Categories.ParentCategory;

namespace Items.Application.Categories.CreateParentCategory
{
    public class CreateParentCategory : IRequest<Guid>
    {
        public string? Title { get; set; }
        public List<ParentCategory>? Category { get; set; } = new();
    }
}
