using BlueBerryDomain = Items.Domain.Models.Categories.Fruits.ConcreteBluBerry.BlueBerry.Blueberry;

namespace Items.Domain.Models.Categories.Fruits.ConcreteBluBerry
{
    public interface IGrowerBlueBerry
    {
        BlueBerryDomain CreateBlueBerry();
    }
}
