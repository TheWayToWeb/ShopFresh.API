using CitrusDomain = Items.Domain.Models.Categories.Fruits.ConcreteCitrus.Citrus.Citrus;

namespace Items.Domain.Models.Categories.Fruits.ConcreteCitrus
{
    public interface IGrowerCitrus
    {
        public CitrusDomain CreateCitrus();
    }
}
