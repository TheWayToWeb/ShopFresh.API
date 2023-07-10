using Items.Domain.Models.Categories.Common;

namespace Items.Domain.Models.Categories.Drinks.MakingTea
{
    public abstract class Tea : Drink
    {
        public string? Grade { get; set; }
        public string? KindOfTea { get; set; }
    }
}
