namespace Diphda.Services
{
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using Diphda.Domain.Abstractions;

    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : BaseEntity
    {
        private readonly IBaseRepository<TEntity> repository;

        public BaseService(IBaseRepository<TEntity> repository)
        {
            this.repository = repository;
        }

        public async Task<int> AddAsync(TEntity entity)
        {
            return await repository.AddAsync(entity);
        }

        public async Task DeleteAsync(int id)
        {
            await repository.DeleteAsync(id);
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await repository.GetAllAsync();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await repository.GetByIdAsync(id);
        }

        public async Task UpdateAsync(TEntity entity)
        {
            await repository.UpdateAsync(entity);
        }
    }
}