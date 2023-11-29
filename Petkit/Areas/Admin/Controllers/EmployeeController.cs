using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Petkit.DAL;
using Petkit.Models;

namespace Petkit.Areas.Admin.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly AppDbContext _context;

        public EmployeeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            List<Employee> employees = await _context.Employees.ToListAsync();

            return View(employees);
        }
    }
}
