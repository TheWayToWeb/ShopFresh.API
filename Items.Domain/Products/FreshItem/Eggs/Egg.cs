using Items.Domain.Enums;

namespace Items.Domain.Products.FreshItem.Eggs
{
    public class Egg : Eat
    {
        public string? Kind { get; set; }
        public Category Grade { get; set; }
    }
}
