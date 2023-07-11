using Microsoft.EntityFrameworkCore;
using PatientPortal_API.Context;
using PatientPortal_API.Repositories.Interfaces;

namespace PatientPortal_API.Repositories.Implementations
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        protected readonly AppDbContext _dbContext;
        private readonly DbSet<T> _dbSet;

        protected Repository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();
        }

        public virtual T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public virtual void Add(T entity)
        {
            _dbSet.Add(entity);
        }

        public virtual void Update(T entity)
        {
            _dbSet.Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }
    }
}
