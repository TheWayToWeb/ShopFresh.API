using Items.Domain.Enums;
using Items.Domain.Products.FreshItem;

namespace Items.Domain.Products.FreshItem.Eggs
{
    public class Egg : Eatable
    {
        public string? Kind { get; set; }
        public Category Sort { get; set; }
        public bool IsFarmer { get; set; }
    }
}
