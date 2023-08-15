namespace Items.Domain.Components.Entities.Categories.Common
{
    public abstract class Bakery : Eat
    {
        public string? ProductBakeryKind { get; set; }
        public string? Addition { get; set; }
    }
}
