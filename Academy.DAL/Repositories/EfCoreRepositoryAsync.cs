using Academy.DAL.DataContext;
using Academy.DAL.Entities;
using Academy.DAL.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.DAL.Repositories
{
    internal class EfCoreRepositoryAsync<T> : IRepositoryAsync<T> where T : Entity
    {
        private readonly AppDbContext _dbContext;
        public async Task AddAsync(T entity)
        {
            _dbContext.Set<T>().Add(entity);
         
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<T>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<T>> GetAllAsync()
        {
            var result = await _dbContext.Set<T>().ToListAsync();

            return result;
        }

        public async Task<T> GetAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(int Id, T entity)
        {
            throw new NotImplementedException();
        }

        Task IRepositoryAsync<T>.GetAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}


