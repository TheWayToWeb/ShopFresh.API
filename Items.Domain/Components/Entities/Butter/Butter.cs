using Items.Domain.Components.Entities.Common;

namespace Items.Domain.Components.Entities.Butter
{
    public class Butter : ItemFood
    {
        public float FatContent { get; private set; }
    }
}
