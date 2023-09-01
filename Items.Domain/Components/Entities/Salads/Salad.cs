using Items.Domain.Components.Entities.Common;
using Items.Domain.Components.Entities.Vegetables;

namespace Items.Domain.Components.Entities.Salads
{
    public class Salad : Vegetable
    {
        public List<ItemFood> SaladIngredients { get; set; } = new();
    }
}
