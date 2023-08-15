using Items.Domain.Components.Entities.Categories.Common;
using Items.Domain.Enums;

namespace Items.Domain.Components.Entities.Categories.Eggs
{
    public class Egg : Eat
    {
        public string? Kind { get; set; }
        public Category Grade { get; set; }
    }
}
