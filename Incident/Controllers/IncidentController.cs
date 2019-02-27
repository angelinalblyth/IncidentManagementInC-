using System.Linq;
using Incident.Data;
using Microsoft.AspNetCore.Mvc;

namespace Incident.Controllers
{
    public class ItemController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ItemController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var model = _context.Incidents.ToList();
            return View("Index", model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View("Create");
        }

        [HttpPost]
        public IActionResult Create(Models.Incident item)
        {
            _context.Incidents.Add(item);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var incident = _context.Incidents.FirstOrDefault(e => e.Id == id);
            _context.Incidents.Remove(incident);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
