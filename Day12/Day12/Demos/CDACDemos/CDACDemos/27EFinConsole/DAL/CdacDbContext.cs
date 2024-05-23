using _27EFinConsole.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

namespace _27EFinConsole.DAL
{
    internal class CdacDbContext :DbContext
    {
        public DbSet<Customer> customers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings.json");
            IConfiguration config = builder.Build();
            var conStr = config.GetSection("ConnectionStrings");
            var str = conStr.GetValue<string>("con");
            optionsBuilder.UseSqlServer(str);
        }
    }
}
