using CitrusDomain = Items.Domain.Components.Entities.Categories.Fruits.ConcreteCitrus.Citrus.Citrus;

namespace Items.Domain.Components.Entities.Categories.Fruits.ConcreteCitrus
{
    public interface IGrowerCitrus
    {
        CitrusDomain CreateCitrus();
    }
}
