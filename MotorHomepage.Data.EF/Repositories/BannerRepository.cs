using MotorHomepage.Data.Entities;
using MotorHomepage.Data.Enums;
using MotorHomepage.Data.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MotorHomepage.Data.EF.Repositories
{
    public class BannerRepository : EFRepository<Banner, int>, IBannerRepository
    {
        AppDbContext _context;
        public BannerRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }


        public List<Banner> GetByStatus(Status status)
        {
            return _context.Banners.Where(x => x.Status == status).ToList();
        }
    }
}
