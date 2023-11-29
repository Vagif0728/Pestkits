using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Petkit.DAL;
using Petkit.Models;
using Petkit.ViewModels;

namespace Petkit.Areas.Admin.Controllers
{
     [Area("Admin")]
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;

        public BlogController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            List<Blog> blogs = await _context.Blogs.ToListAsync();
           
            return View(blogs);
        }
       
    }
}
