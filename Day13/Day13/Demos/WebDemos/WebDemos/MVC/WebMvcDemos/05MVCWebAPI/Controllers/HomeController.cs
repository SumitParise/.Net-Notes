using _05MVCWebAPI.DAL;
using _05MVCWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace _05MVCWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private EmpDbContext _empDbContext;
        public HomeController(EmpDbContext empDbContext)
        {
            _empDbContext = empDbContext;
        }
        // GET: api/<Home>
        [HttpGet]
        public IEnumerable<Emp> Get()
        
        {
            return _empDbContext.emps.ToList();
        }

        // GET api/<Home>/5
        [HttpGet("{id}")]
        public Emp Get(int id)
        {
            return _empDbContext.emps.Find(id);
        }

        // POST api/<Home>
        [HttpPost]
        public void Post([FromBody] Emp emp)
        {
            _empDbContext.emps.Add(emp);
            _empDbContext.SaveChanges();
        }

        // PUT api/<Home>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Emp emp)
        {
            Emp toUpdate= _empDbContext.emps.Find(id);
            toUpdate.Name = emp.Name;
            toUpdate.Address = emp.Address;
            _empDbContext.SaveChanges();
        }

        // DELETE api/<Home>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Emp toDelete = _empDbContext.emps.Find(id);
            _empDbContext.emps.Remove(toDelete);
            _empDbContext.SaveChanges();

        }
    }
}
