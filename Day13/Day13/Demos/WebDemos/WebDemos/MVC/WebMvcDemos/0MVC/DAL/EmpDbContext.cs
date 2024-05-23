using _0MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace _0MVC.DAL
{
    public class EmpDbContext :DbContext
    {
        public DbSet<Emp> emps { get; set; }
        public EmpDbContext(DbContextOptions options):base(options) 
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
