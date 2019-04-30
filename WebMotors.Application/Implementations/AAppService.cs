using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMotors.Application.Abstractions;
using WebMotors.Domain.Abstractions;
using WebMotors.Domain.Abstractions.Service;
using WebMotors.Domain.Implementations;

namespace WebMotors.Application.Implementations
{
    public abstract class AAppService<TViewModel,TEntity,TService> : IAppService<TViewModel, TEntity, TService>
        where TViewModel: class
        where TEntity : class
        where TService : IService<TEntity>
    {
        private readonly IMapper _mapper;
        private readonly TService _service;


        public AAppService(TService service,IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public void Add(TViewModel entity)
        {
            ValidateAdd(entity);

            _service.Add(_mapper.Map<TViewModel,TEntity>(entity));
        }

        public void Delete(TViewModel entity)
        {
            ValidateDelete(entity);

            _service.Delete(_mapper.Map<TViewModel, TEntity>(entity));
        }

        public IEnumerable<TViewModel> FindAll()
        {

            return _service.FindAll().Select(entity=> _mapper.Map<TEntity, TViewModel>(entity));
        }

        public TViewModel FindById(int id)
        {
            return _mapper.Map<TEntity, TViewModel>(_service.FindById(id));
        }

        public void Save()
        {
            _service.Save();
        }

        public void Update(TViewModel entity)
        {
            ValidateUpdate(entity);

            _service.Update(_mapper.Map<TViewModel, TEntity>(entity));
        }

        public abstract void ValidateAdd(TViewModel entity);
        public abstract void ValidateDelete(TViewModel entity);
        public abstract void ValidateUpdate(TViewModel entity);
    }
}
