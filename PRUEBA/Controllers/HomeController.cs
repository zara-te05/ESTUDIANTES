using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using PRUEBA.Models;
using System.Diagnostics;

namespace PRUEBA.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly StudentsDbContext _context;
        public HomeController(ILogger<HomeController> logger, StudentsDbContext context) { 
            _logger = logger;
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Students()
        {
            var allStudents = _context.students.ToList();
            return View(allStudents);
        }

        public IActionResult CreateAndEditStudent(int? id, int age)
        {
            if(age < 18)
            {
                return View();
            }

            if(id != null)
            {
                var expenseInDb = _context.students.SingleOrDefault(x => x.id_alumno == id);
                return View(expenseInDb);
            }

            return View();

        }
        
        public IActionResult DeleteStudent(int? id)
        {
            var expenseInDb = _context.students.SingleOrDefault(x => x.id_alumno == id);
            _context.students.Remove(expenseInDb);
            _context.SaveChanges();
            return RedirectToAction("Students");
        }
        public IActionResult CreateEditStudentsForm(Student model)
        {
            _context.students.Add(model);
            _context.SaveChanges();
            return RedirectToAction("Students");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
