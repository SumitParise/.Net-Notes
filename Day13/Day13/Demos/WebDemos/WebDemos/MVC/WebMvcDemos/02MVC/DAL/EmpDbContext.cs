using _02MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace _02MVC.DAL
{
    public class EmpDbContext:DbContext
    {
        public EmpDbContext(DbContextOptions options):base(options)
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Emp> Emps { get; set; }
    }
}
