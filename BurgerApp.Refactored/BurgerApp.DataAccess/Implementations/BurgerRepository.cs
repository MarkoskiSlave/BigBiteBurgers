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
    public class BurgerRepository : IBurgerRepository
    {
        private readonly BurgerAppDbContext _dbContext;
        public BurgerRepository(BurgerAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task DeleteById(int id)
        {
            Burger burger = _dbContext.Burgers.FirstOrDefault(x => x.BurgerId == id);
            if (burger == null)
            {
                throw new Exception($"The burger with id {id} was not found!");
            }

            _dbContext.Burgers.Remove(burger);
            _dbContext.SaveChanges();
        }

        public async Task<List<Burger>> GetAll()
        {
            return _dbContext.Burgers.ToList();
        }

        public async Task<Burger> GetById(int id)
        {

            return _dbContext.Burgers.FirstOrDefault(x => x.BurgerId == id);
        }

        public async Task Insert(Burger entity)
        {
            _dbContext.Burgers.Add(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Update(Burger entity)
        {
            _dbContext.Burgers.Update(entity);
            await _dbContext.SaveChangesAsync();
        }
    }
}
