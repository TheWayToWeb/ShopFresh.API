using AutoMapper;
using Items.Domain.Components.Feedback;
using Items.Domain.DTOs.Common;

namespace Items.Domain.ViewModel.Reviews
{
    public class ReviewVm : IMapWith<Review>
    {
        public Guid Id { get; set; }
        public int Rating { get; set; }
        public string? Description { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Review, ReviewVm>()
                .ForMember(map => map.Id,
                    opt => opt.MapFrom(map => map.Id))
                .ForMember(map => map.Rating,
                    opt => opt.MapFrom(map => map.Rating))
                .ForMember(map => map.Description,
                    opt => opt.MapFrom(map => map.Description));
        }
    }
}
