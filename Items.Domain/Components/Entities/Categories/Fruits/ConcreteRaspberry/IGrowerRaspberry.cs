using raspberryDomain = Items.Domain.Components.Entities.Categories.Fruits.ConcreteRaspberry.Raspberry.Raspberry;

namespace Items.Domain.Components.Entities.Categories.Fruits.ConcreteRaspberry
{
    public interface IGrowerRaspberry
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
        void SetFarmer(bool value);
        raspberryDomain CreateRaspberry();
    }
}
