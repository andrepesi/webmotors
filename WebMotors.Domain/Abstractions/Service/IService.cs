using System.Collections.Generic;

namespace WebMotors.Domain.Abstractions.Service
{
    public interface IService<TEntity>
    {
        void Add(TEntity entity);
        void Delete(TEntity entity);
        TEntity FindById(int id);
        IEnumerable<TEntity> FindAll();
        void Update(TEntity entity);
        void Save();
    }
}