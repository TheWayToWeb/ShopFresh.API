using MediatR;
using Items.Domain.Products.Category.SubCategory;

namespace Items.Application.Products.CreateSubCategory
{
    public class CreateSubCategory : IRequest<Guid>
    {
        public Guid SubCategoryId { get; set; }
        public string? SubCategoryName { get; set; }
        public List<SubCategory>? FreshGroup { get; set; } = new();
    }
}
