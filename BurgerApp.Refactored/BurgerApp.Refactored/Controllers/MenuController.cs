using BurgerApp.Domain.Models;
using BurgerApp.Models.Domain;
using BurgerApp.Services.Implementations;
using BurgerApp.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BurgerApp.Refactored.Controllers
{
    public class MenuController : Controller
    {
        private readonly IBurgerService _burgerService;
        private readonly IFriesService _friesService;
        private readonly IDrinkService _drinkService;
        private readonly IBestComboService _bestComboService;
        public MenuController(IBurgerService burgerService, IFriesService friesService, IDrinkService drinkService, IBestComboService bestComboService)
        {
            _burgerService = burgerService;
            _drinkService = drinkService;
            _friesService = friesService;
            _bestComboService = bestComboService;
        }
        public IActionResult MainMenu()
        {
            return View();
        }
        public async Task<IActionResult> BurgersMenu() 
        {
            List<Burger> burgers = await _burgerService.AllBurgersForMenu();
            return View(burgers);
        }
        public async Task<IActionResult> FriesMenu()
        {
            List<Fries> fries = await _friesService.AllFriesForMenu();
            return View(fries);
        }
        public async Task<IActionResult> DrinksMenu()
        {
            List<Drink> drinks = await _drinkService.AllDrinksForMenu();
            return View(drinks);
        }
        public async Task<IActionResult> BestComboMenu()
        {
            List<BestCombo> bestComboList = await _bestComboService.AllBestComboForMenu();
            return View(bestComboList);
        }
    }
}
