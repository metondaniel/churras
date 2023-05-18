using ChurrasDomain.Interfaces.Repository;
using ChurrasDomain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ChurrasDomain.Service
{
    public class ServiceBase<T> : IServiceBase<T> where T : class
    {
        public IRepositoryBase<T> _repository;
        public ServiceBase(IRepositoryBase<T> repository)
        { 
            _repository = repository;
        }

        public async Task Add(T entity)
        {
            await _repository.Add(entity);
        }

        public async Task AddRange(IEnumerable<T> entities)
        {
            await _repository.AddRange(entities);
        }

        public async Task<IEnumerable<T>> Find(System.Linq.Expressions.Expression<Func<T, bool>> expression)
        {
            return await _repository.Find(expression);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _repository.GetAll();
        }

        public async Task<T> GetById(int id)
        {
            return await _repository.GetById(id);
        }

        public async Task Remove(T entity)
        {
            await _repository.Remove(entity);
        }

        public async Task RemoveRange(IEnumerable<T> entities)
        {
            await _repository.RemoveRange(entities);
        }
    }
}
