using SelfBlueberry = Items.Domain.Components.Entities.Categories.Fruits.BuilderBluBerry.BlueBerry.Blueberry;

namespace Items.Domain.Components.Entities.Categories.Fruits.BuilderBluBerry
{
    public interface IBuilderBlueberry
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
        SelfBlueberry CreateBlueberry();
    }
}
