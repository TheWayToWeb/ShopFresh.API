using Items.Domain.Models.Categories.Common;

namespace Items.Domain.Models.Categories.MilkProducts
{
    public class Yogurt : Kefir
    {
        public string? TypeConsist { get; set; }
        public List<Taste>? Tastes { get; set; } = new();
    }
}
