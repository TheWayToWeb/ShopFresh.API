using CitrusDomain = Items.Domain.Entities.Categories.Fruits.ConcreteCitrus.Citrus.Citrus;

namespace Items.Domain.Entities.Categories.Fruits.ConcreteCitrus
{
    public interface IGrowerCitrus
    {
        CitrusDomain CreateCitrus();
    }
}
