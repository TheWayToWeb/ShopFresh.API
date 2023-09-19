using Items.Domain.Components.Entities.Common;

namespace Items.Domain.Components.Entities.Milk
{
    public class Milk : ItemFood
    {
        public List<FatContentProduct> FatContents { get; private set; } = new();
        public float Volume { get; set; }
        public bool IsLactoFree { get; private set; }
    }
}
