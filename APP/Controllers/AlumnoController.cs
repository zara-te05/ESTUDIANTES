using APP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APP.Controllers
{
    public class AlumnoController : Controller
    {
        private readonly EscuelaContext _context;

        public AlumnoController(EscuelaContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Estudiantes.ToListAsync());
        }
    }
}
