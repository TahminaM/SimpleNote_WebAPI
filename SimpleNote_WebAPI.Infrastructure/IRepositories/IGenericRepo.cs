﻿

namespace SimpleNote_WebAPI.Infrastructure.IRepositories
{
    public interface IGenericRepo<T> where T : class
    {
        public T GetById(Guid Id);
        public Task<T> GetByIdAsync(Guid id);
        public Task<T> GetByIdAsync(int id);
        public Task<T> GetByIdAsync(Guid? id);
        public T GetById(Guid? id);
        public Task<IEnumerable<T>> GetAllAsync();
        public IEnumerable<T> GetAll();
        public Task<T> DeleteByIdAsync(Guid id);
        public Task DeleteByIdAsync(int id);
        public T DeleteById(Guid id);
        public T Add(T entity);
        public Task<T> UpdateAsync(T TT);
        public Task<T> FindAnyAsync(Expression<Func<T, bool>> match, string[] includesFKdata = null);
        public Task<IEnumerable<T>> FindAllAsync(Expression<Func<T, bool>> match, string[] includesFKdata = null);
        public Task<T> AddAsync(T entity);
    }
}
