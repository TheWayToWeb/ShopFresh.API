using MediatR;
using Items.Domain.Products;

namespace Items.Application.Products.CreateParentCategory
{
    public class CreateParentCategory : IRequest<Guid>
    {
        public Guid TitleId { get; set; }
        public string? Title { get; set; }
        public List<ParentCategory>? Category { get; set; } = new();
    }
}
