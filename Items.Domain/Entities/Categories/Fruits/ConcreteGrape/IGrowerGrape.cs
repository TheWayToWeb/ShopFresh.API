using GrapeDomain = Items.Domain.Models.Categories.Fruits.ConcreteGrape.Grape.Grape;

namespace Items.Domain.Models.Categories.Fruits.ConcreteGrape
{
    public interface IGrowerGrape
    {
        GrapeDomain CreateGrape();
    }
}
