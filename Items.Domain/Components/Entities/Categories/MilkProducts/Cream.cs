using Items.Domain.Components.Entities.Categories.Common;

namespace Items.Domain.Components.Entities.Categories.MilkProducts
{
    public class Cream : LacticProduct
    {
        public string? KindCream { get; set; }
        public List<MilkFat> FatContent { get; set; } = new();

    }
}
