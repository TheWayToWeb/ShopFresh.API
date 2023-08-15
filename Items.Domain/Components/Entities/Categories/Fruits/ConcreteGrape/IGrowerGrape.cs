using GrapeDomain = Items.Domain.Components.Entities.Categories.Fruits.ConcreteGrape.Grape.Grape;

namespace Items.Domain.Components.Entities.Categories.Fruits.ConcreteGrape
{
    public interface IGrowerGrape
    {
        GrapeDomain CreateGrape();
    }
}
