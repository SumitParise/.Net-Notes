using _0MVC.DAL;
using _0MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _0MVC.Controllers
{
    public class HomeController : Controller
    {
        private EmpDbContext _empDbcontext;

        public HomeController(EmpDbContext empDbContext)
        {
            _empDbcontext = empDbContext;
        }

        public IActionResult Index()
        {
            List<Emp> lst= _empDbcontext.emps.ToList();
            return View(lst);
        }

        [HttpGet]
        public IActionResult Create()         
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Emp emp)
        {
            _empDbcontext.emps.Add(emp);
            _empDbcontext.SaveChanges();
            return Redirect("/Home/Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Emp empTobeEdited = _empDbcontext.emps.Find(id);
            return View(empTobeEdited);
        }
        [HttpPost]
        public IActionResult Edit(Emp emp)
        {
           Emp empTobeEdited = _empDbcontext.emps.Find(emp.No);
            empTobeEdited.Name = emp.Name;
            empTobeEdited.Address = emp.Address;
            _empDbcontext.SaveChanges();
            return Redirect("/Home/Index");
        }

    }
}
