
using ForestInfoApi.Data;
using ForestInfoApi.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestInfoApi.Services
{
    public class RepositoryService<T> : IRepository<T> where T : class
    {
        public readonly ForestInfoContext _db;
        public RepositoryService(ForestInfoContext db)
        {
            _db = db;
        }

        public T Add(T entity)
        {
            _db.Set<T>().Add(entity);
            _db.SaveChanges();
            return entity;
        }

        public T Delete(int id)
        {
            var entity = _db.Set<T>().Find(id);
            if (entity == null)
            {
                return null;
            }

            _db.Set<T>().Remove(entity);
            _db.SaveChanges();

            return entity;
        }

        public T GetById(int? id)
        {
            return _db.Set<T>().Find(id);
        }

        public IQueryable<T> GetAll()
        {
            return _db.Set<T>();
        }
        public T Update(T entity)
        {
            _db.Set<T>().Update(entity);
            _db.SaveChanges();
            return entity;
        }
        public async Task<T> AddAsync(T entity)
        {
            _db.Set<T>().Add(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        public async Task<T> DeleteAsync(int? id)
        {

            var entity = await _db.Set<T>().FindAsync(id);
            if (entity == null)
            {
                return null;
            }

            _db.Set<T>().Remove(entity);
            await _db.SaveChangesAsync();

            return entity;
        }

        public async Task<T> GetByIdAsync(int? id)
        {
            return await _db.Set<T>().FindAsync(id);
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _db.Set<T>().ToListAsync();
        }
        public async Task<T> UpdateAsync(T entity)
        {
            _db.Set<T>().Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}