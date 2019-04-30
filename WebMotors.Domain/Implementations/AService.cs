using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMotors.Domain.Abstractions;
using WebMotors.Domain.Abstractions.Service;

namespace WebMotors.Domain.Implementations
{
    public abstract class AService<TEntity,TRepository> : IService<TEntity> 
        where TEntity : class
        where TRepository : IRepository<TEntity>
    {
        private readonly TRepository _repository;

        public AService(TRepository repository)
        {
            _repository = repository;
        }
        public void Add(TEntity entity)
        {
            _repository.Add(entity);
        }

        public void Delete(TEntity entity)
        {
            _repository.Delete(entity);
        }

        public IEnumerable<TEntity> FindAll()
        {
            return _repository.FindAll();
        }

        public TEntity FindById(int id)
        {
            return _repository.FindById(id);
        }

        public void Save()
        {
            _repository.Save();
        }

        public void Update(TEntity entity)
        {
            _repository.Update(entity);
        }
    }
}
