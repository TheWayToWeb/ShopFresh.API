using Items.Domain.Components.Entities.Common;

namespace Items.Domain.Components.Entities.Coffee
{
    public class Coffee : ItemFood
    {
        public string? Type { get; set; }
        public List<ProductTaste> Tastes { get; private set; } = new();
        public string? Kind { get; set; }
        public string? Technology { get; set; }
        public string? Intencity { get; set; }
        public bool IsCoffeinFree { get; private set; }
    }
}
