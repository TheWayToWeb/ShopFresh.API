namespace Items.Domain.Models.Categories.Common
{
    public abstract class Bakery : Eat
    {
        public string? ProductBakeryKind { get; set; }
        public string? Addition { get; set; }
    }
}
