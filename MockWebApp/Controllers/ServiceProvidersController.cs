using Microsoft.AspNetCore.Mvc;
using MockWebApp.Data;
using MockWebApp.Models.Entities;
using MockWebApp.Models;

namespace MockWebApp.Controllers
{
    public class ServiceProvidersController : Controller
    {
        private readonly ApplicationDbContext databaseContext;
        public ServiceProvidersController(ApplicationDbContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }
        [HttpGet]
        public IActionResult Signin()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Signin(ProviderVM providerVM)
        {
            var provider = new Provider
            {
                SPName = providerVM.SPName,
                SPType = providerVM.SPType,
            };
            await databaseContext.ServiceProviders.AddAsync(provider);
            await databaseContext.SaveChangesAsync();
            return View();
        }
    }
}
