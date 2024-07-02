using Microsoft.AspNetCore.Mvc;
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
                    Name = userVM.Name,
                    Email = userVM.Email,
                    Password = userVM.Password,
                    Team = userVM.Team,
                    Jersey = userVM.Jersey,
                };
                await databaseContext.Users.AddAsync(user);
                await databaseContext.SaveChangesAsync();
                return View();
            }
        }
    }
