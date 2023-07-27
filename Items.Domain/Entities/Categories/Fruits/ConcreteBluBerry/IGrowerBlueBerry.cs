using BlueBerryDomain = Items.Domain.Entities.Categories.Fruits.ConcreteBluBerry.BlueBerry.Blueberry;

namespace Items.Domain.Entities.Categories.Fruits.ConcreteBluBerry
{
    public interface IGrowerBlueberry
    {
        BlueBerryDomain CreateBlueberry();
    }
}
