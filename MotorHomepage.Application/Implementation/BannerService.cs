using AutoMapper;
using AutoMapper.QueryableExtensions;
using MotorHomepage.Application.Interfaces;
using MotorHomepage.Application.ViewModels.Banner;
using MotorHomepage.Data.Entities;
using MotorHomepage.Data.IRepositories;
using MotorHomepage.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MotorHomepage.Application.Implementation
{
    public class BannerService : IBannerService
    {
        private IBannerRepository _bannerRepository;
        private IUnitOfWork _unitOfWork;
        public BannerService(IBannerRepository bannerRepository, IUnitOfWork unitOfWork)
        {
            _bannerRepository = bannerRepository;
            _unitOfWork = unitOfWork;
        }
        public BannerViewModel Add(BannerViewModel bannerViewModel)
        {
            var banner = Mapper.Map<BannerViewModel, Banner>(bannerViewModel);
            _bannerRepository.Add(banner);
            return bannerViewModel;
        }

        public void Delete(int id)
        {
            _bannerRepository.Remove(id);
        }

        public List<BannerViewModel> GetAll()
        {
            return _bannerRepository.FindAll().OrderBy(x => x.Id).ProjectTo<BannerViewModel>().ToList();
        }

        public List<BannerViewModel> GetAll(string keyword)
        {
            if (!string.IsNullOrEmpty(keyword))            
                return _bannerRepository.FindAll(x => x.Heading.Contains(keyword) || x.SubHeading.Contains(keyword)).OrderBy(x => x.Id)
                    .ProjectTo<BannerViewModel>().ToList();
            return _bannerRepository.FindAll().OrderBy(x => x.Id)
                .ProjectTo<BannerViewModel>().ToList();
            
        }

        public BannerViewModel GetById(int id)
        {
            return Mapper.Map<Banner, BannerViewModel>(_bannerRepository.FindById(id));
        }

        public void Save()
        {
            _unitOfWork.Comit();
        }

        public void Update(BannerViewModel bannerViewModel)
        {
            throw new NotImplementedException();
        }
    }
}
