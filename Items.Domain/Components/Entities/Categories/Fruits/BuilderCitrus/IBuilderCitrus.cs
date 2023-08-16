using Items.Domain.Components.Entities.Categories.Fruits.BuilderCitrus.Citrus;
using Items.Domain.Components.Entities.Categories.Fruits.Fruit;
using SelfCitrus = Items.Domain.Components.Entities.Categories.Fruits.BuilderCitrus.Citrus.Citrus;

namespace Items.Domain.Components.Entities.Categories.Fruits.BuilderCitrus
{
    public interface IBuilderCitrus : IFruit, ICitrus
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
        CitrusDomain CreateCitrus();
    }
}
