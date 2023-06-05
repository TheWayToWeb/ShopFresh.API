using Items.Domain.Brands;
using Items.Domain.Products.Category.SubCategory.FreshGroup.FreshItem.MilkProducts.LacticEntity;
using MediatR;

namespace Items.Application.Products.ProductMilk.CreateButter
{
    public class CreateButter : IRequest<Guid>
    {
        public string? ItemName { get; set; }
        public int Price { get; set; }
        public string? ImagePath { get; set; }
        public int MinTemp { get; set; }
        public int MaxTemp { get; set; }
        public float? Weight { get; set; }
        public float Protein { get; set; }
        public float Fat { get; set; }
        public float Sugar { get; set; }
        public float Energy { get; set; }
        public int CountInPackage { get; set; }
        public DateOnly BeforeDate { get; set; }
        public bool IsLactoseFree { get; set; }
        public bool IsFarmer { get; set; }
        public bool IsVegan { get; set; }
        public bool IsBestseller { get; set; }
    }
}
