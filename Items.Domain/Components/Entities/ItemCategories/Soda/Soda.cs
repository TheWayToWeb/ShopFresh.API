using Items.Domain.Components.Entities.Categories.Common;

namespace Items.Domain.Components.Entities.Categories.Soda
{
    public class Soda : ItemFood
    {
        public List<ProductTaste> Tastes { get; private set; } = new();
        public List<SoldCapacity> Volume { get; private set; } = new();
        public bool IsCold { get; private set; }
    }
}
