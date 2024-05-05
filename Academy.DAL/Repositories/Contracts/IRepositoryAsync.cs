using Academy.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.DAL.Repositories.Contracts
{
    public interface IRepositoryAsync<T> where T : Entity
    {
        Task<ICollection<T>> GetAll();
        Task<T> GetAsync(int Id);
        Task AddAsync(T entity);
        Task UpdateAsync(int Id,T entity);
        Task DeleteAsync(T entity);
        Task GetAllAsync();
    }
}
