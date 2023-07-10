using Items.Domain.Models.Categories.Common;

namespace Items.Domain.Models.Categories.MilkProducts
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
