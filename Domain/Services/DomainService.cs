using Domain.Entities;
using Domain.Interfaces.Repository;
using Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class DomainService<TEntity>(IRepositoryBase<TEntity> repository) : IDomainService<TEntity> where TEntity : Entity
    {//dispose, executesqlasync, tirar detachLocal e seed e nomes em português, listallasync
        public Task<TEntity> AddAsync(TEntity entity)
        {
            return repository.GetByIdAsync(entity);
        }

        public Task<IEnumerable<TEntity>> Buscar(Expression<Func<TEntity, bool>> predicate)
        {
            return repository.Buscar(predicate);
        }

        public Task<int> CountAsync(ISpecification<TEntity> spec)
        {
            return repository.CountAsync(spec);
        }

        public Task<int> DeleteAsync(TEntity entity)
        {
            return repository.DeleteAsync(entity);
        }

        public void DetachAll()
        {
            repository.DetachAll();
        }

        public void DetachLocal(Func<TEntity, bool> predicate)
        {
            repository.DetachLocal(predicate);
        }

        public int ExecuteSql(string sql)
        {
            return repository.ExecuteSql(sql);
        }

        public Task<TEntity> FirstAsync(ISpecification<TEntity> spec)
        {
            return repository.FirstAsync(spec);
        }

        public Task<TEntity> FirstOrDefaultAsync(ISpecification<TEntity> spec)
        {
            return repository.FirstOrDefaultAsync(spec);
        }

        public Task<TEntity> GetByIdAsync(int id)
        {
            return repository.GetByIdAsync(id);
        }

        public Task<IReadOnlyList<TEntity>> ListAllAsync()
        {
            return repository.ListAllAsync();
        }

        public Task<PagedResult<TEntity>> ListAllPagedAsync(int page, int pageSize)
        {
            return repository.ListAllPagedAsync(page, pageSize);
        }

        public Task<IReadOnlyList<TEntity>> ListAsync(ISpecification<TEntity> spec)
        {
            return repository.ListAsync(spec);
        }

        public Task<PagedResult<TEntity>> ListPagedAsync(ISpecification<TEntity> spec, int page, int pageSize)
        {
            return repository.ListPagedAsync(spec, page, pageSize);
        }

        public void Seed(IEnumerable<TEntity> data)
        {
            repository.Seed(data);
        }

        public Task<int> UpdateAsync(TEntity entity)
        {
            return repository.UpdateAsync(entity);
        }
    }
}
