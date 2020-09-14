using System;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Infrastructure
{
    public class AppDbContext : DbContext
    {
        public DbSet<Card> Cards { get; set; }
        public DbSet<Coupon> Coupons { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
    }
}