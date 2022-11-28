﻿


namespace SimpleNote_WebAPI.Infrastructure.IRepositoriesImp
{
    public class GenericRepoImp<T>: IGenericRepo<T> where T:class
    {
        protected ApplicationDbContext _db;

        public GenericRepoImp(ApplicationDbContext db)
        {
            _db = db;
        }
        
        public T Add(T entity)
        {
            _db.Set<T>().Add(entity);
            _db.SaveChanges();
            return entity;
        }

        public async Task<T> AddAsync(T entity)
        {
            await _db.Set<T>().AddAsync(entity);
            _db.SaveChanges();
            return entity;
        }

        public T DeleteById(Guid id)
        {
            var TT = GetById(id);
            _db.Set<T>().Remove(TT);
            _db.SaveChanges();
            return TT;
        }

        public async Task<T> DeleteByIdAsync(Guid id)
        {
            var TT = await GetByIdAsync(id);
            _db.Set<T>().Remove(TT);
            _db.SaveChanges();
            return TT;
        }

        public async Task<T> FindAnyAsync(Expression<Func<T, bool>> match, string[] includesFKdata = null)
        {
            IQueryable<T> query = _db.Set<T>();

            if (includesFKdata != null)
            {
                foreach (var includesFK in includesFKdata)
                {
                    query = query.Include(includesFK);
                }
            }

            return await query.FirstOrDefaultAsync(match);

        }

        public async Task<IEnumerable<T>> FindAllAsync(Expression<Func<T, bool>> match, string[] includesFKdata = null)
        {
            IQueryable<T> query = _db.Set<T>();

            if (includesFKdata != null)
            {
                foreach (var includesFK in includesFKdata)
                {
                    query = query.Include(includesFK);
                }
            }

            return await query.Where(match).ToListAsync();

        }

        public IEnumerable<T> GetAll()
        {
            return _db.Set<T>().ToList();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            var result = await _db.Set<T>().ToListAsync();
            return result;
        }

        public T GetById(Guid? id)
        {
            return _db.Set<T>().Find(id);
        }

        public async Task<T> GetByIdAsync(Guid? id)
        {
            var TT = await _db.Set<T>().FindAsync(id);
            return TT;
        }

        public async Task<T> UpdateAsync(T TT)
        {
            _db.Set<T>().Update(TT);
            _db.SaveChanges();
            return TT;
        }


        public T GetById(Guid id)
        {
            var TT = _db.Set<T>().Find(id);
            return TT;
        }

        public async Task<T> GetByIdAsync(Guid id)
        {
            var TT = await _db.Set<T>().FindAsync(id);
            return TT;
        }

        public async Task<T> GetByIdAsync(int id)
        {
            var TT = await _db.Set<T>().FindAsync(id);
            return TT;
        }

        public async Task DeleteByIdAsync(int id)
        {
            var TT = await GetByIdAsync(id);
            _db.Set<T>().Remove(TT);
            await _db.SaveChangesAsync();
        }
    }
}
