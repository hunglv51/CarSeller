using Car4U.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Car4U.Infrastructure.Data
{
    public class CarSellerContext : DbContext
    {
      

        public CarSellerContext(DbContextOptions<CarSellerContext> options) : base(options)
        {

        }
        public DbSet<Post> Posts { get; set; }
        public DbSet<CarImage> CarImages { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<PostCategory> PostCategories { get; set; }
        public DbSet<Notification> Notifications { get; set; }
    }
}
