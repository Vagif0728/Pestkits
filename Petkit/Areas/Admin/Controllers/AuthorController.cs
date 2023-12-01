using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Petkit.DAL;
using Petkit.Models;

namespace Petkit.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AuthorController : Controller
    {
        private readonly AppDbContext _context;

        public AuthorController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            List<Author> authors = await _context.Authors.Include(x => x.Blogs).ToListAsync();
            return View(authors);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Author author)
        {
            bool result = await _context.Authors.AnyAsync(x => x.Name == author.Name);

            if (!ModelState.IsValid)
            {
                return View();
            }

            if (result)
            {
                ModelState.AddModelError("Fullname", "Eyni adli yazici yarana bilmez");
                return View();
            }

            await _context.AddAsync(author);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Update(int id)
        {
            Author author = await _context.Authors.FirstOrDefaultAsync(x => x.Id == id);

            if (author == null) return NotFound();

            return View(author);
        }

        [HttpPost]
        public async Task<IActionResult> Update(int? id, Author author)
        {
            Author exist = await _context.Authors.FirstOrDefaultAsync(x => x.Id == id);

            if (exist == null) return NotFound();

            bool result = await _context.Authors.AnyAsync(x => x.Name == author.Name);

            if (!ModelState.IsValid)
            {
                return View(exist);
            }

            if (result)
            {
                ModelState.AddModelError("Fullname", "Eyni adli yazici yarana bilmez");
                return View(exist);
            }

            exist.Name = author.Name;

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            Author exist = await _context.Authors.FirstOrDefaultAsync(x => x.Id == id);

            if (exist == null) return NotFound();

            _context.Authors.Remove(exist);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

       public async Task<IActionResult> Detail(int id,Author author)
        {
            Author exist = await _context.Authors.FirstOrDefaultAsync(x => x.Id == id);
            if (exist == null) return NotFound();

            bool result = await _context.Authors.AnyAsync(x => x.Name == author.Name);

           
            return View(exist);
        }
    }
}

