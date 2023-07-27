using GrapeDomain = Items.Domain.Entities.Categories.Fruits.ConcreteGrape.Grape.Grape;

namespace Items.Domain.Entities.Categories.Fruits.ConcreteGrape
{
    public interface IGrowerGrape
    {
        GrapeDomain CreateGrape();
    }
}
