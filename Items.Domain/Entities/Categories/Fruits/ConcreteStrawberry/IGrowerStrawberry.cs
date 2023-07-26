using StrawberryDomain = Items.Domain.Entities.Categories.Fruits.ConcreteStrawberry.Strawberry.Strawberry;

namespace Items.Domain.Entities.Categories.Fruits.ConcreteStrawberry
{
    public interface IGrowerStrawberry
    {
        StrawberryDomain CreateStrawberry();
    }
}
