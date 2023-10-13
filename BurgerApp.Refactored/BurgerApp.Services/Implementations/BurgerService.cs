using BurgerApp.DataAccess.Implementations;
using BurgerApp.DataAccess.Interfaces;
using BurgerApp.Models.Domain;
using BurgerApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerApp.Services.Implementations
{
    public class BurgerService : IBurgerService
    {
        private readonly IBurgerRepository _burgerRepository;
        public BurgerService(IBurgerRepository burgerRepository)
        {
            _burgerRepository = burgerRepository;
        }

        public async Task<List<Burger>> AllBurgersForMenu()
        {
            return await _burgerRepository.GetAll();
        }
    }
}
