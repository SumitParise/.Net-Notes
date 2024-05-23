using _05MVCWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace _05MVCWebAPI.DAL
{
    public class EmpDbContext:DbContext
    {
        public DbSet<Emp> emps { get; set; }
        public EmpDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
