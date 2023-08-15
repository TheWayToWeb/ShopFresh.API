using Items.Domain.Components.Entities.Categories.Common;

namespace Items.Domain.Components.Entities.Categories.MilkProducts
{
    public class Yogurt : Kefir
    {
        public string? TypeConsist { get; set; }
        public List<Taste>? Tastes { get; set; } = new();
    }
}
