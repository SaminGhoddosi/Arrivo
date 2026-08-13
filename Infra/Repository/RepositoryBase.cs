using Domain.Entities;
using Domain.Interfaces.Repository;
using Paging;
using Microsoft.EntityFrameworkCore;
using Ardalis.Specification;
using Ardalis.Specification.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Infra.Repository
{
    public class RepositoryBase<TEntity>(AppDbContext dbContext) : IRepository<TEntity> where TEntity : Entity
    {
        public async Task<TEntity> AddAsync(TEntity entity)
        {
            dbContext.Set<TEntity>().Add(entity);
            await dbContext.SaveChangesAsync();
            return entity;
        }

        public IQueryable<TEntity> ApplySpecification(ISpecification<TEntity> spec)
        {
            return SpecificationEvaluator.Default.GetQuery(dbContext.Set<TEntity>(), spec);
        }

        public async Task<IEnumerable<TEntity>> Search(Expression<Func<TEntity, bool>> predicate)
        {
            return await dbContext.Set<TEntity>().AsNoTracking().Where(predicate).ToListAsync();
        }

        public async Task<int> CountAsync(ISpecification<TEntity> spec)
        {
            var speficationResult = ApplySpecification(spec);
            return await speficationResult.CountAsync();
        }

        public async Task<int> DeleteAsync(TEntity entity)
        {
            dbContext.Set<TEntity>().Remove(entity);
            return await dbContext.SaveChangesAsync();
        }

        public async Task<TEntity> FirstAsync(ISpecification<TEntity> spec)
        {
            var specificationResult = ApplySpecification(spec);
            return await specificationResult.FirstAsync();
        }

        public async Task<TEntity> FirstOrDefaultAsync(ISpecification<TEntity> spec)
        {
            var specificationResult = ApplySpecification(spec);
            return await specificationResult.FirstOrDefaultAsync();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await dbContext.Set<TEntity>().FindAsync(id);
        }

        public async Task<IEnumerable<TEntity>> ListAllAsync()
        {
            return await dbContext.Set<TEntity>().AsNoTracking().ToListAsync();
        }

        public Task<PagedResult<TEntity>> ListAllPagedAsync(int page, int pageSize)
        {
            var list = dbContext.Set<TEntity>().AsNoTracking().GetPaged(page, pageSize);
            return Task.FromResult(list);
        }

        public async Task<IEnumerable<TEntity>> ListAsync(ISpecification<TEntity> spec)
        {
            var specificationResult = ApplySpecification(spec);
            return await specificationResult.AsNoTracking().ToListAsync();
        }

        public async Task<PagedResult<TEntity>> ListPagedAsync(ISpecification<TEntity> spec, int page, int pageSize)
        {
            var specificationResult = ApplySpecification(spec);
            return await Task.FromResult(specificationResult.GetPaged(page, pageSize));
        }

        public async Task<int> UpdateAsync(TEntity entity)
        {
            dbContext.Entry(entity).State = EntityState.Modified;
            return await dbContext.SaveChangesAsync();
        }

    }
}
