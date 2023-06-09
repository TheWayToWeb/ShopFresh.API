using Items.Domain.Products.Template;

namespace Items.Domain.Products.FreshItem.MilkProducts
{
    public class DrinkMilk : Drink
    {
        public string? Taste { get; set; }
        public List<MilkFat> FatContent { get; set; } = new();
        public string? ProcessMilk { get; set; }
        public string? KindOfMilk { get; set; }
        public string? Raw { get; set; }
        public bool IsLactoseFree { get; set; }
        public bool IsFarmer { get; set; }
        public bool IsVegan { get; set; }
        public bool IsBestseller { get; set; }
    }
}
