using BurgerApp.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerApp.Services.Interfaces
{
    public interface IService<T>
    {
        Task <List<T>> GetAll();
        Task<T> GetById(int id);
        Task Create(T entity);
        Task Delete(int id);
        Task Update(T entity);
    }
}
