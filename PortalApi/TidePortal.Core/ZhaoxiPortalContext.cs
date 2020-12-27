using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TidePortal.Entity;

namespace TidePortal.Core
{
    public class ZhaoxiPortalContext : DbContext
    {
        public ZhaoxiPortalContext()
        {
        }
        //执行完带参构造函数后还会继续执行基类构造函数
        public ZhaoxiPortalContext(DbContextOptions<ZhaoxiPortalContext> options) : base(options)
        {
        }
        public DbSet<Users> Users { get; set; }
        public DbSet<Resources> Resources { get; set; }
        public DbSet<UserResourceMapping> UserResourceMapping { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //似乎是如果配置里没有就会执行这个？
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-FG071FQ;Initial Catalog=TidePortal;Integrated Security=True");
            }
        }

        //这些都是额外的似乎都不需要
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>(entity =>
            {
                //entity.ToTable("Users");
                entity.HasComment("网站用户");
                entity.Property(e => e.Id).HasComment("编号");
                entity.Property(e => e.CreateTime).HasColumnType("datetime").HasComment("创建时间");
                entity.Property(e => e.Mobile).HasMaxLength(12);
            });
            modelBuilder.Entity<Resources>(entity =>
            {
                //entity.ToTable("Users");
                entity.HasComment("课程资源");
                entity.Property(e => e.Id).HasComment("编号");
                entity.Property(e => e.CreateTime).HasColumnType("datetime").HasComment("创建时间");
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
