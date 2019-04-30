using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMotors.Application.Abstractions
{
    public interface IAppService<TViewModel, TEntity, TService>
    {
        void Add(TViewModel entity);
        void Delete(TViewModel entity);
        TViewModel FindById(int id);
        IEnumerable<TViewModel> FindAll();
        void Update(TViewModel entity);
        void Save();
    }
}
