using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMotors.Domain.Abstractions
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        void Delete(TEntity entity);
        TEntity FindById(int id);
        IEnumerable<TEntity> FindAll();
        void Update(TEntity entity);
        void Save();
    }
}
