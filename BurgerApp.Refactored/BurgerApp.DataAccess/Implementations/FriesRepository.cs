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
    public class FriesRepository : IFriesRepository
    {
        private readonly BurgerAppDbContext _dbContext;
        public FriesRepository(BurgerAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task DeleteById(int id)
        {
            Fries fries = _dbContext.Fries.FirstOrDefault(x => x.FriesId == id);
            if (fries == null)
            {
                throw new Exception($"The fries with id {id} was not found!");
            }

            _dbContext.Fries.Remove(fries);
            _dbContext.SaveChanges();
        }

        public async Task<List<Fries>> GetAll()
        {
            return _dbContext.Fries.ToList();
        }

        public async Task<Fries> GetById(int id)
        {

            return _dbContext.Fries.FirstOrDefault(x => x.FriesId == id);
        }

        public async Task Insert(Fries entity)
        {
            _dbContext.Fries.Add(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Update(Fries entity)
        {
            _dbContext.Fries.Update(entity);
            await _dbContext.SaveChangesAsync();
        }
    }
}
