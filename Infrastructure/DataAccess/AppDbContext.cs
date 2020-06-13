using System;
using Cards.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.DataAccess
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
    : base(options)
        {
        }
        public DbSet<Card> Cards { get; set; }
    }
}