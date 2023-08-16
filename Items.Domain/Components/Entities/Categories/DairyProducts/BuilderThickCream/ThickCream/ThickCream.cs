using Items.Domain.Components.Entities.Categories.DairyProducts.BuilderMilk.Milk;
using Items.Domain.Products.Template;

namespace Items.Domain.Components.Entities.Categories.DairyProducts.BuilderThickCream.ThickCream
{
    public class ThickCream : Milk
    {
        public bool IsHalal { get; set; }
    }
}
