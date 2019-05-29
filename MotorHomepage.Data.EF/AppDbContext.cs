using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

using System;
using System.IO;
using System.Linq;

using MotorHomepage.Data.EF.Configurations;
using MotorHomepage.Data.EF.Extensions;
using MotorHomepage.Data.Entities;
using MotorHomepage.Data.Interfaces;

namespace MotorHomepage.Data.EF
{
    public class AppDbContext : IdentityDbContext<AppUser, AppRole, Guid>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        #region DbSet
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppRole> AppRoles { get; set; }
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
            builder.Entity<IdentityUserClaim<Guid>>().ToTable("AppUserClaims").HasKey(c => c.Id);
            builder.Entity<IdentityRoleClaim<Guid>>().ToTable("AppRoleClaims").HasKey(c => c.Id);
            builder.Entity<IdentityUserLogin<Guid>>().ToTable("AppUserLogins").HasKey(c => c.UserId);
            builder.Entity<IdentityUserRole<Guid>>().ToTable("AppUserRoles").HasKey(c => c.UserId);
            builder.Entity<IdentityUserToken<Guid>>().ToTable("AppUserTokens").HasKey(c => c.UserId);
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

            //base.OnModelCreating(builder);
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
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("D:\\Project Hyosung\\MotorHomepage\\MotorHomepage\\appsettings.json").Build();
            var builder = new DbContextOptionsBuilder<AppDbContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            builder.UseSqlServer(connectionString);
            return new AppDbContext(builder.Options);
        }
    }
}
