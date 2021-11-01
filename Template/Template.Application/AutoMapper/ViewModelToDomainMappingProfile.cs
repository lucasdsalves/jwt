using AutoMapper;
using Template.Application.ViewModels;
using Template.Domain.DTOs;

namespace Template.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            AuthRequestViewModelToUserDto();
        }

        private void AuthRequestViewModelToUserDto()
        {
            CreateMap<AuthRequestViewModel, UserDTO>()
                .ForMember(x => x.Username, opt => opt.MapFrom(x => x.Username))
                .ForMember(x => x.Password, opt => opt.MapFrom(x => x.Password));
        }
    }
}
