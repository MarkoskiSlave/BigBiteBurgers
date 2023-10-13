using BurgerApp.DataAccess.Implementations;
using BurgerApp.DataAccess.Interfaces;
using BurgerApp.Domain.Models;
using BurgerApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerApp.Services.Implementations
{
    public class DrinkService : IDrinkService
    {
        private IDrinkRepository _drinkRepository;
        public DrinkService(IDrinkRepository drinkRepository)
        {
            _drinkRepository = drinkRepository;
        }
        public async Task<List<Drink>> AllDrinksForMenu()
        {
            return await _drinkRepository.GetAll();
        }
    }
}
