﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MotorHomepage.Data.EF.Extensions;
using MotorHomepage.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MotorHomepage.Data.EF.Configurations
{
    public class BannerKoConfiguration : DbEntityConfiguration<BannerKo>
    {
        public override void Configure(EntityTypeBuilder<BannerKo> entity)
        {
            entity.HasKey(c => c.Id);
        }
    }
}
