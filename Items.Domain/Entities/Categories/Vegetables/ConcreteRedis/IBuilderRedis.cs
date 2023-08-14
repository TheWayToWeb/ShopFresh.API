using Items.Domain.Entities.Categories.Vegetables.ConcreteRedis.Redis;
using Items.Domain.Entities.Categories.Vegetables.Vegetable;
using RedisConcrete = Items.Domain.Entities.Categories.Vegetables.ConcreteRedis.Redis.Redis;

namespace Items.Domain.Entities.Categories.Vegetables.ConcreteRedis
{
    public interface IBuilderRedis: IVegetable, IRedis
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
        void SetFarmer(bool value);
        void SetCoolingMode(string value);
        RedisConcrete CreateRedis();
    }
}
