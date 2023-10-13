using BurgerApp.DataAccess.Interfaces;
using BurgerApp.Domain.Models;
using BurgerApp.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerApp.DataAccess.Implementations
{
    public class DrinkRepository : IDrinkRepository
    {
        private readonly BurgerAppDbContext _dbContext;
        public DrinkRepository(BurgerAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task DeleteById(int id)
        {
            Drink drink = _dbContext.Drinks.FirstOrDefault(x => x.DrinkId == id);
            if (drink == null)
            {
                throw new Exception($"The drink with id {id} was not found!");
            }

            _dbContext.Drinks.Remove(drink);
            _dbContext.SaveChanges();
        }

        public async Task<List<Drink>> GetAll()
        {
            return _dbContext.Drinks.ToList();
        }

        public async Task<Drink> GetById(int id)
        {

            return _dbContext.Drinks.FirstOrDefault(x => x.DrinkId == id);
        }

        public async Task Insert(Drink entity)
        {
            _dbContext.Drinks.Add(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Update(Drink entity)
        {
            _dbContext.Drinks.Update(entity);
            await _dbContext.SaveChangesAsync();
        }
    }
}
