using ProjetoFortes.Domain.Interface.Repositories;
using ProjetoFortes.Domain.Interface.Services;
using System.Collections.Generic;

namespace ProjetoFortes.Dominio.Services
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {
        private readonly IBaseRepository<TEntity> _repository;

        public ServiceBase(IBaseRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public void Add(TEntity obj)
        {
            _repository.Add(obj);
        }
        
        public IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public TEntity GetById(int id)
        {
            return _repository.GetById(id);
        }

        public void Remove(TEntity obj)
        {
            _repository.Remove(obj);
        }

        public void Update(TEntity obj)
        {
            _repository.Update(obj);
        }
    }
}
