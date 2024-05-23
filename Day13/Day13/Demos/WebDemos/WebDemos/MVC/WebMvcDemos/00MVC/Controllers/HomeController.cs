using _00MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _00MVC.Controllers
{
    public class HomeController : Controller
    {
        //public HomeController(ISpellCheker checker)
        //{
            
        //}
        //public HomeController(IEnumerable<ISpellCheker> checker)
        //{
            
        //}
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public IActionResult Index()
        {
            ViewData["UserName"] = "Hugh Jackman";
            ViewBag.Greet = "Lets learn MVC together!";
            return View();
        }

        public IActionResult GetData()
        {
            Emp emp=new Emp() {Id=10,Name="Sagar",Address="Beed" };
            return View("GetData",emp);
        }

        public IActionResult Privacy()
        {
            List<Emp> lst = new List<Emp>() { 
             new Emp(){Id= 11, Name="Ganesh",Address="Pune"},
             new Emp(){Id= 12, Name="Suresh",Address="Satara"},
             new Emp(){Id= 13, Name="Dipesh",Address="Devgad"},
             new Emp(){Id= 14, Name="Nagesh",Address="Nagpur"}
            };
            List<Cust> lstcust = new List<Cust>() {
             new Cust(){Id= 11, Name="Ganesh1",Address="Pune1"},
             new Cust(){Id= 12, Name="Suresh1",Address="Satara1"},
             new Cust(){Id= 13, Name="Dipesh1",Address="Devgad1"},
             new Cust(){Id= 14, Name="Nagesh1",Address="Nagpur1"}
            };
            return View(lstcust);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
