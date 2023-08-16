using Items.Domain.Components.Entities.Categories.Common;

namespace Items.Domain.Components.Entities.Categories.Eggs
{
    public class Egg : ItemFood
    {
        public string? Category { get; private set; }
        public string? Kind { get; private set; }
        public string? Size { get; private set; }
    }
}
