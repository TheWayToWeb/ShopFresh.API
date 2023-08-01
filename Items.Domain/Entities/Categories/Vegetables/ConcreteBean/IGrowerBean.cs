using beanDomain = Items.Domain.Entities.Categories.Vegetables.ConcreteBean.Bean.Bean;

namespace Items.Domain.Entities.Categories.Vegetables.ConcreteBean
{
    public interface IGrowerBean
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
        void SetGrade(string value);
        void SetSlicingShape(bool value);
        beanDomain CreateBean();
    }
}
