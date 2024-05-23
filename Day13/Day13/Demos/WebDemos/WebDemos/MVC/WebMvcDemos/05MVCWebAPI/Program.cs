using _05MVCWebAPI.DAL;
using Microsoft.EntityFrameworkCore;

namespace _05MVCWebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<EmpDbContext>(options => {
                options.UseSqlServer("name=con");
            });

            // Add services to the container.

            builder.Services.AddControllers();

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
