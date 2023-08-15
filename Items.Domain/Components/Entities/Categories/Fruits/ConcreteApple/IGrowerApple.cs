using AppleDomain = Items.Domain.Components.Entities.Categories.Fruits.ConcreteApple.Apple.Apple;

namespace Items.Domain.Components.Entities.Categories.Fruits.ConcreteApple
{
    public interface IGrowerApple
    {
        AppleDomain CreateApple();
    }
}
