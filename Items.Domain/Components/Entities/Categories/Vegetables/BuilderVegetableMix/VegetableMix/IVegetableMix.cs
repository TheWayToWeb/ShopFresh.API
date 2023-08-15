using SelfVegetable = Items.Domain.Components.Entities.Categories.Vegetables.Vegetable.Vegetable;

namespace Items.Domain.Components.Entities.Categories.Vegetables.BuilderVegetableMix.VegetableMix
{
    public interface IVegetableMix
    {
        void AddVegetables(List<SelfVegetable> value);
    }
}
