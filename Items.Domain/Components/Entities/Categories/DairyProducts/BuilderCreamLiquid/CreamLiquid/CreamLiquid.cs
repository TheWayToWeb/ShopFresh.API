using Items.Domain.Components.Entities.Categories.MilkProducts.Common;

namespace Items.Domain.Components.Entities.Categories.DairyProducts.BuilderCreamLiquid.CreamLiquid
{
    public class CreamLiquid : LacticProduct
    {
        public string? KindCream { get; set; }
        public List<FatContentProduct> FatContent { get; set; } = new();

    }
}
