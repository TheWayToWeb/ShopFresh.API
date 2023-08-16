using Items.Domain.Components.Entities.Categories.Common;
using Items.Domain.Components.Entities.Categories.MilkProducts.Common;

namespace Items.Domain.Components.Entities.Categories.DairyProducts.BuilderMilk.Milk
{
    public class Milk : Drink
    {
        public string? Taste { get; set; }
        public List<FatContentProduct> FatContent { get; set; } = new();
        public string? ProcessMilk { get; set; }
        public string? KindOfMilk { get; set; }
        public string? Raw { get; set; }
        public bool IsLactoseFree { get; set; }
        public bool IsFarmer { get; set; }
        public bool IsVegan { get; set; }
        public bool IsBestseller { get; set; }
    }
}
