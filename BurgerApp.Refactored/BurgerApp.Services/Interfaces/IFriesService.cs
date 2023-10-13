using BurgerApp.Domain.Models;
using BurgerApp.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerApp.Services.Interfaces
{
    public interface IFriesService
    {
        Task<List<Fries>> AllFriesForMenu();
    }
}
