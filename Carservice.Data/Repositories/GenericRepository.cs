using Carservice.Data.Entities.Abstract;
using Carservice.Data.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Carservice.Data.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : BaseEntity, new()
    {
        protected DbContext context;
        protected DbSet<T> dbSet;
        public bool AutoSaveChanges { get; set; } = true;
        public GenericRepository(DbContext dbContext)
        {
            context = dbContext;
            dbSet = dbContext.Set<T>();
        }
        public IQueryable<T> GetAll()
        {
            return dbSet;
        }
        
        public virtual async Task<ICollection<T>> GetAllAsyn()
        {
            return await dbSet.ToListAsync();
        }
        public virtual T Get(int id)
        {
            return dbSet.Find(id);
        }
        public virtual async Task<T> GetAsync(int id)
        {
            return await dbSet.FindAsync(id);
        }
        public virtual T Add(T t)
        {
            dbSet.Add(t);
            context.SaveChanges();
            return t;
        }
        public virtual async Task<T> AddAsyn(T t)
        {
            dbSet.Add(t);
            await context.SaveChangesAsync();
            return t;
        }
        public virtual T Find(Expression<Func<T, bool>> match)
        {
            return dbSet.SingleOrDefault(match);
        }
        public virtual async Task<T> FindAsync(Expression<Func<T, bool>> match)
        {
            return await dbSet.SingleOrDefaultAsync(match);
        }
        public ICollection<T> FindAll(Expression<Func<T, bool>> match)
        {
            return dbSet.Where(match).ToList();
        }
        public async Task<ICollection<T>> FindAllAsync(Expression<Func<T, bool>> match)
        {
            return await dbSet.Where(match).ToListAsync();
        }

        public virtual void Delete(T entity)
        {
            dbSet.Remove(entity);
            context.SaveChanges();
        }
        public virtual async Task<int> DeleteAsyn(T entity)
        {
            dbSet.Remove(entity);
            return await context.SaveChangesAsync();
        }
        public virtual T Update(T t, object key)
        {
            if (t == null)
                return null;
            T exist = dbSet.Find(key);
            if (exist != null)
            {
                context.Entry(exist).CurrentValues.SetValues(t);
                context.SaveChanges();
            }
            return exist;
        }
        public virtual async Task<T> UpdateAsyn(T t, object key)
        {
            if (t == null)
                return null;
            T exist = await dbSet.FindAsync(key);
            if (exist != null)
            {
                context.Entry(exist).CurrentValues.SetValues(t);
                await context.SaveChangesAsync();
            }
            return exist;
        }
        public int Count()
        {
            return dbSet.Count();
        }
        public async Task<int> CountAsync()
        {
            return await dbSet.CountAsync();
        }
        public virtual void Save()
        {
            context.SaveChanges();
        }
        public async virtual Task<int> SaveAsync()
        {
            return await context.SaveChangesAsync();
        }
        public virtual IQueryable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            IQueryable<T> query = dbSet.Where(predicate);
            return query;
        }
        public virtual async Task<ICollection<T>> FindByAsyn(Expression<Func<T, bool>> predicate)
        {
            return await dbSet.Where(predicate).ToListAsync();
        }
        public IQueryable<T> GetAllIncluding(params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> queryable = GetAll();
            foreach (Expression<Func<T, object>> includeProperty in includeProperties)
            {
                queryable = queryable.Include<T, object>(includeProperty);
            }
            return queryable;
        }
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
                disposed = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Delete(int id)
        {
            var entity = Get(id);
            Delete(entity);
        }
    }
}
