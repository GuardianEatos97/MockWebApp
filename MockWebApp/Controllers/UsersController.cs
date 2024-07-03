using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MockWebApp.Data;
using MockWebApp.Models;
using MockWebApp.Models.Entities;

namespace MockWebApp.Controllers
{
    public class UsersController : Controller
    {
        private readonly ApplicationDbContext databaseContext;
        public UsersController(ApplicationDbContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(UserVM userVM)
        {
            var user = new User
            {
                UserName = userVM.UserName,
                UserEmail = userVM.UserEmail,
                UserPassword = userVM.UserPassword,
                UserTeam = userVM.UserTeam,
                UserJersey = userVM.UserJersey,
            };
            await databaseContext.Users.AddAsync(user);
            await databaseContext.SaveChangesAsync();
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> List()
        { 
        var athletes = await databaseContext.Users.ToListAsync();
            return View(athletes);
        }

        
    
    
    
    }
}
