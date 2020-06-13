using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;

namespace Infrastructure.DataAccess
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=pharmadb;Trusted_Connection=True;", b=>b.MigrationsAssembly("Infrastructure"));
            return new AppDbContext(optionBuilder.Options);
        }
    }
}
namespace DbConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}