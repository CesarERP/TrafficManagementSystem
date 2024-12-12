using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TrafficManagementSystem.Models;

namespace TrafficManagementSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly TrafficDbContext _context; // Inyección del DbContext

        public HomeController(ILogger<HomeController> logger, TrafficDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
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

        // Métodos CRUD para Vehiculo
        public IActionResult Vehiculos()
        {
            var vehiculos = _context.Vehiculos.ToList();
            return View(vehiculos);
        }

        public IActionResult CreateVehiculo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateVehiculo(Vehiculo vehiculo)
        {
            if (ModelState.IsValid)
            {
                _context.Vehiculos.Add(vehiculo);
                _context.SaveChanges();
                return RedirectToAction(nameof(Vehiculos));
            }
            return View(vehiculo);
        }

        public IActionResult EditVehiculo(int id)
        {
            var vehiculo = _context.Vehiculos.Find(id);
            if (vehiculo == null) return NotFound();
            return View(vehiculo);
        }

        [HttpPost]
        public IActionResult EditVehiculo(Vehiculo vehiculo)
        {
            if (ModelState.IsValid)
            {
                _context.Vehiculos.Update(vehiculo);
                _context.SaveChanges();
                return RedirectToAction(nameof(Vehiculos));
            }
            return View(vehiculo);
        }

        public IActionResult DeleteVehiculo(int id)
        {
            var vehiculo = _context.Vehiculos.Find(id);
            if (vehiculo == null) return NotFound();
            _context.Vehiculos.Remove(vehiculo);
            _context.SaveChanges();
            return RedirectToAction(nameof(Vehiculos));
        }
    }
}
