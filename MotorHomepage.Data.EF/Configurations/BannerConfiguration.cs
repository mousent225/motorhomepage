using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MotorHomepage.Data.EF.Extensions;
using MotorHomepage.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MotorHomepage.Data.EF.Configurations
{
    public class BannerConfiguration : DbEntityConfiguration<Banner>
    {
        public override void Configure(EntityTypeBuilder<Banner> entity)
        {
            entity.HasKey(c => c.Id);
        }
    }
}
