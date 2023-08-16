using Items.Domain.Components.Entities.Categories.DairyProducts.BuilderThickDairyProduct.ThickDairyProduct;
using Items.Domain.Components.Entities.Categories.MilkProducts.Common;

namespace Items.Domain.Components.Entities.Categories.DairyProducts.BuilderYogurt.Yogurt
{
    public class Yogurt : ThickDairyProduct
    {
        public string? TypeConsist { get; set; }
        public List<ProductTaste>? Tastes { get; set; } = new();
    }
}
