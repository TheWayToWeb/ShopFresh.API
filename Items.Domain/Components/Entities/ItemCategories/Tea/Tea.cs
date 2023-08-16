using Items.Domain.Components.Entities.Categories.Common;

namespace Items.Domain.Components.Entities.Categories.Tea
{
    public class Tea: ItemFood
    {
        public string? Grade { get; private set; }
        public string? TeaKind { get; private set; }
    }
}
