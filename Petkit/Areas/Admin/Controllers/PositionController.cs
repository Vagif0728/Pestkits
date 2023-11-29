using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Petkit.DAL;
using Petkit.Models;

namespace Petkit.Areas.Admin.Controllers
{
    public class PositionController : Controller
    {
        private readonly AppDbContext _context;

        public PositionController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            List<Position> positions = await _context.Positions.ToListAsync();

            return View(positions);
        }
    }
}
