using BurgerApp.DataAccess;
using BurgerApp.DataAccess.Implementations;
using BurgerApp.DataAccess.Interfaces;
using BurgerApp.Domain.Models;
using BurgerApp.Models.Domain;
using BurgerApp.Services.Implementations;
using BurgerApp.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerApp.Helpers
{
    public static class InjectionHelper
    {
        public static void InjectRepositories(IServiceCollection services)
        {
            services.AddTransient<IBurgerRepository, BurgerRepository>();
            services.AddTransient<IDrinkRepository, DrinkRepository>();
            services.AddTransient<IBestComboRepository, BestComboRepository>();
            services.AddTransient<IFriesRepository, FriesRepository>();
        }

        public static void InjectServices(IServiceCollection services)
        {
            services.AddTransient<IBurgerService, BurgerService>();
            services.AddTransient<IDrinkService, DrinkService>();
            services.AddTransient<IFriesService, FriesService>();
            services.AddTransient<IBestComboService, BestComboService>();
        }

        public static void InjcetDbContext(this IServiceCollection services, string connString)
        {
            services.AddDbContext<BurgerAppDbContext>(options =>
                options.UseSqlServer(connString));
        }
    }
}
