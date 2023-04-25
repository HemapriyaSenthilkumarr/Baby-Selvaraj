using Emp_register1web.Data;
using Emp_register1web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Emp_register1web.Controllers
{
    //Constructor to initialize the logger and the database content 
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ApplicationDbContext _db;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }
        //Action method to display the home page
        public IActionResult Index()
        {
            return View();
        }
        //Action method to display the empregister page with the list of registerd employees
        public IActionResult Employee()
        {
            IEnumerable<EmpRegister> objEmpList = _db.EmpRegister;
            return View(objEmpList);
        }

        //Action method to form submission to add new employee
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(EmpRegister obj) 
        {
            if (ModelState.IsValid) 
            {
                _db.EmpRegister.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "Registered successfully";
                return RedirectToAction("Employee");
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}