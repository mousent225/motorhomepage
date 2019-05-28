using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using MotorHomepage.Data.EF.Configurations;
using MotorHomepage.Data.EF.Extensions;
using MotorHomepage.Data.Entities;
using MotorHomepage.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MotorHomepage.Data.EF
{
    public class AppDbContext : IdentityDbContext<AppUser, AppRole, Guid>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        #region DbSet
        public DbSet<Attachment> Attachments { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<BannerKo> BannerKos { get; set; }
        public DbSet<BannerVi> BannerVis { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostKo> PostKos { get; set; }
        public DbSet<PostVi> PostVis { get; set; }
        public DbSet<SysCategory> SysCategories { get; set; }
        public DbSet<SysCategoryValue> SysCategoryValues { get; set; }
        public DbSet<SysDictionary> SysDictionaries { get; set; }
        public DbSet<SysMenu> SysMenus { get; set; }
        #endregion
        protected override void OnModelCreating(ModelBuilder builder)
        {
            #region IdentityConfig
            builder.Entity<IdentityUserClaim<string>>().ToTable("AppUserClaims").HasKey(c => c.Id);
            builder.Entity<IdentityRoleClaim<string>>().ToTable("AppRoleClaims").HasKey(c => c.Id);
            builder.Entity<IdentityUserLogin<string>>().ToTable("AppUserClaims").HasKey(c => c.UserId);
            builder.Entity<IdentityUserRole<string>>().ToTable("AppUserRoles").HasKey(c => c.UserId);
            builder.Entity<IdentityUserToken<string>>().ToTable("AppUserTokens").HasKey(c => c.UserId);
            #endregion

            builder.AddConfiguration(new AttachmentConfiguration());
            builder.AddConfiguration(new BannerConfiguration());
            builder.AddConfiguration(new BannerKoConfiguration());
            builder.AddConfiguration(new BannerViConfiguration());
            builder.AddConfiguration(new PostConfiguration());
            builder.AddConfiguration(new PostKoConfiguration());
            builder.AddConfiguration(new PostViConfiguration());
            builder.AddConfiguration(new SysCategoryConfiguration());
            builder.AddConfiguration(new SysCategoryValueConfiguration());
            builder.AddConfiguration(new SysDictionaryConfiguration());
            builder.AddConfiguration(new SysMenuConfiguration());

            base.OnModelCreating(builder);
        }

        public override int SaveChanges()
        {
            var modified = ChangeTracker.Entries().Where(e => e.State == EntityState.Modified || e.State == EntityState.Added);
            foreach (EntityEntry item in modified)
            {
                var changedOrAddedItem = item.Entity as IDateTracking;
                if (changedOrAddedItem != null)
                {
                    if (item.State == EntityState.Added)
                        changedOrAddedItem.DateCreated = DateTime.Now;
                    changedOrAddedItem.DateModified = DateTime.Now;
                }
            }
            return base.SaveChanges();
        }
    }
}
