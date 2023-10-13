using BurgerApp.DataAccess.Implementations;
using BurgerApp.DataAccess.Interfaces;
using BurgerApp.Domain.Models;
using BurgerApp.Models.Domain;
using BurgerApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerApp.Services.Implementations
{
    public class FriesService : IFriesService
    {
        private IFriesRepository _friesRepository;
        public FriesService(IFriesRepository friesRepository)
        {
            _friesRepository = friesRepository;
        }
        public async Task<List<Fries>> AllFriesForMenu()
        {
            return await _friesRepository.GetAll();
        }
    }
}
