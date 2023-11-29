using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Petkit.DAL;
using Petkit.Models;

namespace Petkit.Areas.Admin.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly AppDbContext _context;

        public DepartmentController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            List<Department> departments = await _context.Departments.ToListAsync();

            return View(departments);
        }
    }
}
