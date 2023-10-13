using BurgerApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerApp.Services.Interfaces
{
    public interface IBestComboService
    {
        Task<List<BestCombo>> AllBestComboForMenu();
    }
}
