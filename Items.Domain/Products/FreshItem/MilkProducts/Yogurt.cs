using Items.Domain.Products.Template;

namespace Items.Domain.Products.FreshItem.MilkProducts
{
    public class Yogurt : Kefir
    {
        public string? TypeConsist { get; set; }
        public List<Taste>? Tastes { get; set; } = new();
    }
}
