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
    public class BestComboRepository : IBestComboRepository
    {
        private readonly BurgerAppDbContext _dbContext;
        public BestComboRepository(BurgerAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task DeleteById(int id)
        {
            BestCombo bestCombo = _dbContext.BestCombos.FirstOrDefault(x => x.BestComboId == id);
            if (bestCombo == null)
            {
                throw new Exception($"The bestCombo with id {id} was not found!");
            }

            _dbContext.BestCombos.Remove(bestCombo);
            _dbContext.SaveChanges();
        }

        public async Task<List<BestCombo>> GetAll()
        {
            return _dbContext.BestCombos.ToList();
        }

        public async Task<BestCombo> GetById(int id)
        {
            
            return _dbContext.BestCombos.FirstOrDefault(x => x.BestComboId == id);
        }

        public async Task Insert(BestCombo entity)
        {
           _dbContext.BestCombos.Add(entity);
           await _dbContext.SaveChangesAsync();
        }

        public async Task Update(BestCombo entity)
        {
            _dbContext.BestCombos.Update(entity);
            await _dbContext.SaveChangesAsync();
        }
    }
}
