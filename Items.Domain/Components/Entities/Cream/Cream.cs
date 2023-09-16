using Items.Domain.Components.Entities.Common;

namespace Items.Domain.Components.Entities.Cream
{
    public class Cream : ItemFood
    {
        public float Volume { get; private set; }
        public List<FatContentProduct> FatContents { get; set; } = new();
        public bool IsLactoseFree { get; set; }
    }
}
