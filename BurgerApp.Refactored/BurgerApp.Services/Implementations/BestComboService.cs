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
    public class BestComboService : IBestComboService
    {
        private IBestComboRepository _bestComboRepository;
        public BestComboService(IBestComboRepository bestComboRepository)
        {
            _bestComboRepository = bestComboRepository;
        }
        public async Task<List<BestCombo>> AllBestComboForMenu()
        {
            return await _bestComboRepository.GetAll();
        }
    }
}
