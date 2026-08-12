using Domain.Entities;
using Domain.Interfaces.Repository;
using Domain.Interfaces.Services;
using Paging;
using Ardalis.Specification;
using System.Linq.Expressions;

namespace Domain.Services
{
    public class DomainService<TEntity>(IRepository<TEntity> repository) : IDomainService<TEntity> where TEntity : Entity
    {
        public Task<TEntity> AddAsync(TEntity entity)
        {
            return repository.AddAsync(entity);
        }

        public Task<IEnumerable<TEntity>> Search(Expression<Func<TEntity, bool>> predicate)
        {
            return repository.Search(predicate);
        }

        public Task<int> CountAsync(ISpecification<TEntity> spec)
        {
            return repository.CountAsync(spec);
        }

        public Task<int> DeleteAsync(TEntity entity)
        {
            return repository.DeleteAsync(entity);
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

        public Task<IEnumerable<TEntity>> ListAllAsync()
        {
            return repository.ListAllAsync();
        }

        public Task<PagedResult<TEntity>> ListAllPagedAsync(int page, int pageSize)
        {
            return repository.ListAllPagedAsync(page, pageSize);
        }

        public Task<IEnumerable<TEntity>> ListAsync(ISpecification<TEntity> spec)
        {
            return repository.ListAsync(spec);
        }

        public Task<PagedResult<TEntity>> ListPagedAsync(ISpecification<TEntity> spec, int page, int pageSize)
        {
            return repository.ListPagedAsync(spec, page, pageSize);
        }

        public Task<int> UpdateAsync(TEntity entity)
        {
            return repository.UpdateAsync(entity);
        }
    }
}
