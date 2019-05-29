using MotorHomepage.Application.ViewModels.Banner;
using System;
using System.Collections.Generic;
using System.Text;

namespace MotorHomepage.Application.Interfaces
{
    public interface IBannerService
    {
        BannerViewModel Add(BannerViewModel bannerViewModel);
        void Update(BannerViewModel bannerViewModel);
        void Delete(int id);
        List<BannerViewModel> GetAll();
        List<BannerViewModel> GetAll(string keyword);
        BannerViewModel GetById(int id);
        void Save();
    }
}
