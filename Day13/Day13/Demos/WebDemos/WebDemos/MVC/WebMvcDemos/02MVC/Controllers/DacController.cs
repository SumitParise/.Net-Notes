using _02MVC.DAL;
using _02MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace _02MVC.Controllers
{
    public class DacController : Controller
    {
        private EmpDbContext _empDbContext;
        public DacController(EmpDbContext empDbContext)
        {
            _empDbContext = empDbContext;
        }
        public IActionResult Index()
        {
            List<Emp> lstEmp = _empDbContext.Emps.ToList();
            return View();
        }
        public IActionResult Create() 
        {
            return View();
        }
        public IActionResult Edit(Emp emp)
        {
            
            return View();
        }
        public IActionResult Delete(int id)
        {
            return Redirect("/Dac/Index");
        }
    }
}
