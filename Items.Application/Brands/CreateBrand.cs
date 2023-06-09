using MediatR;

namespace Items.Application.Brands
{
    public class CreateBrand : IRequest<Guid>
    {
        public string? BrandName { get; set; }
    }
}
