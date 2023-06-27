using Items.Domain.Products.Template;

namespace Items.Domain.Products.FreshItem.Drinks.MakingWater
{
    public class Water : Drink
    {
        public bool IsSparkling { get; set; }
        public string? Purpose { get; set; }
    }
}
