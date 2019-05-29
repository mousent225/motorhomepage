using AutoMapper;
using MotorHomepage.Application.ViewModels.Banner;
using MotorHomepage.Data.Entities;

namespace MotorHomepage.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<BannerViewModel, Banner>().ConstructUsing(c=> new Banner(c.Heading, c.SubHeading, c.Description, c.Image, c.UserCreated, c.DateCreated
                ,c.UserModified,  c.DateModified, c.Status, c.PublishStatus, c.IsDeleted, c.DateDeleted, c.UserDeleted));
        }
    }
}
