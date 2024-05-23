using _01MVC.DAL;
using _01MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _01MVC.Controllers
{
    public class HomeController : Controller
    {
        EmpDbContextcs db =new EmpDbContextcs();
        public IActionResult Index()
        {
            List<Emp> lstEmps = db.SelectEmpRecord();

            return View(lstEmps);
        }

        public IActionResult Create() 
        {
            return View();
        }

        //I am binding UI data to a method Parameter
        //So we are telling ModelBinder to map this collection values to Mdel Emp
        //Forms-Collection1.Name = Emp.Name
        //Forms-Collection1.Address = Emp.Address
        public IActionResult AfterCreate(Emp emp)
        {
            int rowsAffted = db.InsertEmpRecord(emp);
            if(rowsAffted > 0) 
            {
                return Redirect("/Home/Index");//instructions to browser - to generate GET call
            }
            else
            {
                return View("Create");
            }
            
        }
        public IActionResult Edit(int id)
        {
           List<Emp> emps = db.SelectEmpRecord().ToList();
            
            var emp = (from e in emps
                      where e.No == id
                      select e).First();
            return View(emp);
        }

        public IActionResult AfterEdit(Emp emp)
        {
            List<Emp> emps = db.SelectEmpRecord().ToList();

            var empToBeUpdted = (from e in emps
                       where e.No == emp.No
                       select e).First();
            db.UpdateEmpRecord(emp);
            return Redirect("/Home/Index");
        }

        public IActionResult Delete(int id)
        {
            db.DeleteEmpRecord(id);
            return Redirect("/Home/Index");
        }
    }
}
