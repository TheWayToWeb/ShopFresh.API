using seaBucthornDomain = Items.Domain.Components.Entities.Categories.Fruits.ConcreteSeaBucthorn.SeaBucthorn.SeaBucthorn;

namespace Items.Domain.Components.Entities.Categories.Fruits.ConcreteSeaBucthorn
{
    public interface IGrowerSeaBucthorn
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
        seaBucthornDomain CreateSeaBucthorn();
    }
}
