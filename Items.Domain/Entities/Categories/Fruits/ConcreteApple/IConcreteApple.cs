using AppleDomain = Items.Domain.Models.Categories.Fruits.ConcreteApple.Apple.Apple;

namespace Items.Domain.Models.Categories.Fruits.ConcreteApple
{
    public interface IConcreteApple
    {
        AppleDomain CreateApple();
    }
}
