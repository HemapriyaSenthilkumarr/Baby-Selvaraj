using Emp_register1web.Data;
using Emp_register1web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Emp_register1web.Controllers
{
    public class EmpRegisterController : Controller
    {
        private readonly ApplicationDbContext _db;
        public EmpRegisterController(ApplicationDbContext db) 
        {
            _db = db;
        }
		//return view containing a list of all the empregister object in the database 
		public IActionResult Index()
        {
            IEnumerable<EmpRegister> objEmpList = _db.EmpRegister;
            return View(objEmpList);
        }
        

    }
}
