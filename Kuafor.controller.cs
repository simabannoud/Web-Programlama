// Models/Employee.cs
namespace KuaforApp.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Specialty { get; set; }
        public bool IsAvailable { get; set; }
    }
}

// Models/Service.cs
namespace KuaforApp.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Duration { get; set; } // Duration in minutes
    }
}

// Data/ApplicationDbContext.cs
using Microsoft.EntityFrameworkCore;
using KuaforApp.Models;

namespace KuaforApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Service> Services { get; set; }
    }
}

// Controllers/HomeController.cs
using Microsoft.AspNetCore.Mvc;
using KuaforApp.Data;
using System.Linq;

namespace KuaforApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var employees = _context.Employees.ToList();
            var services = _context.Services.ToList();
            ViewBag.Employees = employees;
            ViewBag.Services = services;
            return View();
        }
    }
}
