using Items.Domain.Components.Entities.Categories.Fruits.BuilderBanana.Banana;
using Items.Domain.Components.Entities.Categories.Fruits.Fruit;
using SelfBanana = Items.Domain.Components.Entities.Categories.Fruits.BuilderBanana.Banana.Banana;

namespace Items.Domain.Components.Entities.Categories.Fruits.BuilderBanana
{
    public interface IBuilderBanana : IFruit, IBanana
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
        void SetFarmer(bool value);
        void SetCoolingMode(string value);
        SelfBanana CreateBanana();
    }
}
