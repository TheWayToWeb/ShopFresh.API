using BlueBerryDomain = Items.Domain.Components.Entities.Categories.Fruits.ConcreteBluBerry.BlueBerry.Blueberry;

namespace Items.Domain.Components.Entities.Categories.Fruits.ConcreteBluBerry
{
    public interface IGrowerBlueberry
    {
        BlueBerryDomain CreateBlueberry();
    }
}
