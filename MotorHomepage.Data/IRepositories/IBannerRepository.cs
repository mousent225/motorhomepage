using MotorHomepage.Data.Entities;
using MotorHomepage.Data.Enums;
using MotorHomepage.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MotorHomepage.Data.IRepositories
{
    public interface IBannerRepository : IRepository<Banner, int>
    {
        List<Banner> GetByStatus(Status status);
    }
}
