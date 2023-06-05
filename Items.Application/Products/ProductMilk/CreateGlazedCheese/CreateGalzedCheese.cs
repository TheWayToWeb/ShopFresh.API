using Items.Domain.Products.Category.SubCategory.FreshGroup.FreshItem.MilkProducts;
using MediatR;

namespace Items.Application.Products.ProductMilk.CreateGlazedCheese
{
    public class CreateGalzedCheese : IRequest<Guid>
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
        public string? Taste { get; set; }
        public float FatContent { get; set; }
        public bool IsHalal { get; set; }
    }
}
