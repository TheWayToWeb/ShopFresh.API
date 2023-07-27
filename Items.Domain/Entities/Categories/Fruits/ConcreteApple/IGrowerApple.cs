using AppleDomain = Items.Domain.Entities.Categories.Fruits.ConcreteApple.Apple.Apple;

namespace Items.Domain.Entities.Categories.Fruits.ConcreteApple
{
    public interface IGrowerApple
    {
        AppleDomain CreateApple();
    }
}
