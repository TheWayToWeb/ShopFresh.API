using Items.Domain.Components.Entities.Common;

namespace Items.Domain.Components.Entities.Tea
{
    public class Tea : ItemFood
    {
        public string? Grade { get; private set; }
        public string? TeaKind { get; private set; }
    }
}
