using Items.Domain.Components.Entities.Common;

namespace Items.Domain.Components.Entities.Coffee
{
    public class Coffee : ItemFood
    {
        public List<ProductTaste> Tastes { get; private set; } = new();
        public string? TypeCoffee { get; private set; }
        public string? KindCoffee { get; private set; }
        public string? ConsistencyRelease { get; private set; }
        public string? Composition { get; private set; }
        public string? IntencityRelease { get; private set; }
        public bool IsCoffeinFree { get; private set; }
    }
}
