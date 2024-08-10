using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Tech_Top.Models;

namespace Tech_Top.Controllers
{
    public class HomeController(TechContext context) : Controller
    {
        private readonly TechContext _context = context;

        public IActionResult Index()
        {
            List<TechModel> techModels = _context.TechModels.ToList();
            return View(techModels);
        }

        public IActionResult AddTech()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddTech(TechModel techModel)
        {
            if (ModelState.IsValid)
            {
                _context.TechModels.Add(techModel);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(techModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
