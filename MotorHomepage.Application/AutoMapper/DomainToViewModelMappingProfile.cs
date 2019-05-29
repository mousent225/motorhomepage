using AutoMapper;
using MotorHomepage.Application.ViewModels.Banner;
using MotorHomepage.Data.Entities;

namespace MotorHomepage.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Banner, BannerViewModel>();
        }
    }
}
