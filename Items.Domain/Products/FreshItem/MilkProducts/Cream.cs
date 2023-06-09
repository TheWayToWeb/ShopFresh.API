using Items.Domain.Products.Template;

namespace Items.Domain.Products.FreshItem.MilkProducts
{
    public class Cream : LacticProduct
    {
        public string? KindCream { get; set; }
        public List<MilkFat> FatContent { get; set; } = new();

    }
}
