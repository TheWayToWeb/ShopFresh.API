using SelfVegetable = Items.Domain.Entities.Categories.Vegetables.Vegetable.Vegetable;

namespace Items.Domain.Entities.Categories.Vegetables.ConcreteVegetableMix.VegetableMix
{
    public interface IVegetableMix
    {
        void AddVegetables(List<SelfVegetable> value);
    }
}
