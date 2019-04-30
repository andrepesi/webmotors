using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMotors.Domain.Abstractions;

namespace WebMotors.Infra.Data
{
    public abstract class ARepository<TEntity> : IRepository<TEntity> where TEntity : class,TKey
    {
        private readonly WebMotorsContext _context;
        private readonly DbSet<TEntity> _dbSet;
        private readonly IUnitOfWork _unitOfWork;

        public ARepository(IUnitOfWork uow)
        {
            _unitOfWork = uow;
            _context = uow.GetContext() as WebMotorsContext;
            _dbSet = _context.Set<TEntity>();
        }
        public void Add(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public void Delete(TEntity entity)
        {
            _dbSet.Attach(entity);
            _dbSet.Remove(entity);
        }

        public IEnumerable<TEntity> FindAll()
        {
            return _dbSet.AsNoTracking().ToList();
        }

        public TEntity FindById(int id)
        {
            return _dbSet.Where(x=> x.Id == id).AsNoTracking().FirstOrDefault();
        }

        public void Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }
        public void Save()
        {
            _unitOfWork.Save();
        }
    }
}
