using Microsoft.AspNetCore.Mvc;
using MockWebApp.Models;
using System.Diagnostics;

namespace MockWebApp.Controllers
{
    public class WorkoutController : Controller
    {
        private readonly ILogger<WorkoutController> _logger;

        public WorkoutController(ILogger<WorkoutController> logger)
        {
            _logger = logger;
        }

        public IActionResult CurrentProgramWorkout()
        {
            return View();
        }
        public IActionResult SelectExercise()
        {
            return View();
        }
        public IActionResult BodyPartSelect()
        {
            return View();
        }

        public IActionResult SelectTeamAndPreview()
        {
            return View();
        }
        public IActionResult WorkoutNav()
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
