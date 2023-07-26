using RaspberryDomain = Items.Domain.Entities.Categories.Fruits.ConcreteRaspberry.Raspberry.Raspberry;

namespace Items.Domain.Entities.Categories.Fruits.ConcreteRaspberry
{
    public interface IGrowerRaspberry
    {
        RaspberryDomain CreateRaspberry();
    }
}
