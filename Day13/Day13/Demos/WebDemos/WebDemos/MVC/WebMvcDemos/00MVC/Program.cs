using _00MVC.Models;

namespace _00MVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            
            // DI Container

            //IspellChecker dependency
            builder.Services.AddScoped(typeof(ISpellCheker), typeof(EnglishSpellChecker));
            builder.Services.AddScoped(typeof(ISpellCheker), typeof(HindiSpellChecker));
            
            // Add services to the container.
            builder.Services.AddControllersWithViews();
            //builder.Services.AddControllers();
           
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}