using SelfApple = Items.Domain.Components.Entities.Categories.Fruits.BuilderApple.Apple.Apple;
using SalesLine = Items.Domain.Components.Entities.Categories.Fruits.Common.SalesLine;
using Items.Domain.Components.Entities.Categories.Fruits.Fruit;
using Items.Domain.Components.Entities.Categories.Fruits.BuilderApple.Apple;

namespace Items.Domain.Components.Entities.Categories.Fruits.BuilderApple
{
    public interface IBuilderApple : IFruit, IApple
    {
        void SetPrice(int value);
        void SetImagePath(string value);
        void SetMaker(string value);
        void SetMinTemp(int value);
        void SetMaxTemp(int value);
        void SetProtein(float value);
        void SetFat(float value);
        void SetSugar(float value);
        void SetEnergy(float value);
        void SetCountInPackage(int value);
        void SetCreatedDate(int value);
        void SetWeight(float value);
        void SetCoolingMode(string value);
        SelfApple CreateApple();
    }
}
