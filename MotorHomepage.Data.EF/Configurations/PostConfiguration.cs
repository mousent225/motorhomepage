using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MotorHomepage.Data.EF.Extensions;
using MotorHomepage.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MotorHomepage.Data.EF.Configurations
{
    public class PostConfiguration : DbEntityConfiguration<Post>
    {
        public override void Configure(EntityTypeBuilder<Post> entity)
        {
            entity.HasKey(c => c.Id);
        }
    }
}
