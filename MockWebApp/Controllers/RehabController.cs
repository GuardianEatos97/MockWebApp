using Microsoft.AspNetCore.Mvc;
using MockWebApp.Models;
using System.Diagnostics;

namespace MockWebApp.Controllers
{
    public class RehabController: Controller
    {
        private readonly ILogger<RehabController> _logger;

        public RehabController(ILogger<RehabController> logger)
        {
            _logger = logger;
        }

        public IActionResult PhysioCP()
        {
            return View();
        }
        public IActionResult SelectAthlete()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
