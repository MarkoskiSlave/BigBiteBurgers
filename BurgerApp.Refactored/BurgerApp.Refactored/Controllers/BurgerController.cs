using BurgerApp.Models.Domain;
using BurgerApp.Services.Implementations;
using BurgerApp.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BurgerApp.Refactored.Controllers
{
    public class BurgerController : Controller
    {
        private IBurgerService _burgerService;
        public BurgerController(IBurgerService burgerService)
        {
            _burgerService = burgerService;
        }
        public async Task<IActionResult> SeeMenu()
        {
            List<Burger> burgers = await _burgerService.AllBurgersForMenu();
            return View(burgers);
        }
    }
}
