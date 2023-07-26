using Items.Domain.Enums;
using Items.Domain.Models.Categories.Common;

namespace Items.Domain.Models.Categories.Eggs
{
    public class Egg : Eat
    {
        public string? Kind { get; set; }
        public Category Grade { get; set; }
    }
}
