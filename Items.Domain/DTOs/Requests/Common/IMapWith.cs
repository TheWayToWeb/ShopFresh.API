using AutoMapper;

namespace Items.Domain.DTOs.Requests.Common
{
    public interface IMapWith<T>
    {
        void Mapping(Profile profile) => profile.CreateMap(typeof(T), GetType());
    }
}
