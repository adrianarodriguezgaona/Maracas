using Maracas.Lib.Models;
using MaracasMusic.API.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MaracasMusic.API.Repositories
{
    public class RepositoryBase<T> : IRepository<T> where T : EntityBase
    {
        protected readonly MaracasContext _maracasContext;
        public RepositoryBase(MaracasContext maracasContext)
        {
            _maracasContext = maracasContext;
        }
        public virtual async Task<T> Add(T entity)
        {
            _maracasContext.Set<T>().Add(entity);
            try
            {
                await _maracasContext.SaveChangesAsync();
            }
            catch
            {
                return null;
            }
            return entity;

        }


        public async Task<T> Delete(T entity)
        {
            _maracasContext.Set<T>().Remove(entity);
            try
            {
                await _maracasContext.SaveChangesAsync();
            }
            catch
            {
                return null;
            }
            return entity;
        }

        public async Task<T> Delete(int id)
        {
            var entity = await GetById(id);
            if (entity == null) return null;
            return await Delete(entity);
        }

        public IQueryable<T> GetAll()
        {
            return _maracasContext.Set<T>().AsNoTracking();
        }

        public virtual async Task<T> GetById(int id)
        {
            return await _maracasContext.Set<T>().FindAsync(id);
        }

        public virtual IQueryable<T> GetFiltered(Expression<Func<T, bool>> predicate)
        {
            return _maracasContext.Set<T>()
                .Where(predicate).AsNoTracking();
        }

        public async virtual Task<IEnumerable<T>> GetFilteredList(Expression<Func<T, bool>> predicate)
        {
            return await GetFiltered(predicate).ToListAsync();
        }

        public async Task<IEnumerable<T>> ListAll()
        {
            return await GetAll().ToListAsync();
        }

        public async Task<T> Update(T entity)
        {
            _maracasContext.Entry(entity).State = EntityState.Modified;
            try
            {
                await _maracasContext.SaveChangesAsync();
            }
            catch
            {
                return null;
            }
            return entity;
        }

        private async Task<bool> Exists (int id)
        {
            return await _maracasContext.Set<T>().AnyAsync(e => e.Id == id);
        }
    }
}
