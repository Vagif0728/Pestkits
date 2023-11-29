using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Petkit.DAL;
using Petkit.Models;
using Petkit.ViewModels;

namespace Petkit.Controllers;

public class HomeController : Controller
{
    private readonly AppDbContext _context;

    public HomeController(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        List<Blog> blogs = await _context.Blogs.ToListAsync();
        List<Employee> employees = await _context.Employees.ToListAsync();
        List<Department> departments= await _context.Departments.ToListAsync();
        List<Position> positions= await _context.Positions.ToListAsync();
        List<Author> authors = await _context.Authors.ToListAsync();

        HomeVM homeVM = new HomeVM { Blogs = blogs, Employees = employees ,Department=departments,Positions=positions,Author=authors};
        return View(homeVM);
    }

    public IActionResult Privacy()
    {
        return View();
    }

   
}