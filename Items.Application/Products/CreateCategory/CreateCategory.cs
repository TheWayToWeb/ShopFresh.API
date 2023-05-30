using MediatR;
using Items.Domain.Products.Category;
using System.Web.Http;

namespace Items.Application.Products.CreateCategory
{
    public class CreateCategory : IRequest<Guid>
    {
        public Guid CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public List<Category>? SubCategory { get; set; } = new();
    }
}
