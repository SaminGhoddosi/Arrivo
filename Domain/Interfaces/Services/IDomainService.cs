using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Ardalis.Specification;
using Paging;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services
{
    public interface IDomainService<TEntity> where TEntity : Entity
    {
        Task<TEntity> GetByIdAsync(int id);
        Task<IEnumerable<TEntity>> ListAllAsync();
        Task<IEnumerable<TEntity>> ListAsync(ISpecification<TEntity> spec);
        Task<PagedResult<TEntity>> ListAllPagedAsync(int page, int pageSize);
        Task<PagedResult<TEntity>> ListPagedAsync(ISpecification<TEntity> spec, int page, int pageSize);
        Task<TEntity> AddAsync(TEntity entity);
        Task<int> UpdateAsync(TEntity entity);
        Task<int> DeleteAsync(TEntity entity);
        Task<int> CountAsync(ISpecification<TEntity> spec);
        Task<TEntity> FirstAsync(ISpecification<TEntity> spec);
        Task<TEntity> FirstOrDefaultAsync(ISpecification<TEntity> spec);
        Task<IEnumerable<TEntity>> Search(Expression<Func<TEntity, bool>> predicate);
    }
}
