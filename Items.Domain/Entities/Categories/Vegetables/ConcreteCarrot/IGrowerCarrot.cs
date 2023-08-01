using carrotDomain = Items.Domain.Entities.Categories.Vegetables.ConcreteCarrot.Carrot.Carrot;

namespace Items.Domain.Entities.Categories.Vegetables.ConcreteCarrot
{
    public interface IGrowerCarrot
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
        void SetGrade(string value);
        void SetSlicingShape(bool value);
        carrotDomain CreateCarrot();
    }
}
