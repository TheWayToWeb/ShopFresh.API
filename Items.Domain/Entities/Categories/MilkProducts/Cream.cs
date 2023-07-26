using Items.Domain.Models.Categories.Common;

namespace Items.Domain.Models.Categories.MilkProducts
{
    public class Cream : LacticProduct
    {
        public string? KindCream { get; set; }
        public List<MilkFat> FatContent { get; set; } = new();

    }
}
