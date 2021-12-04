namespace Diphda.Services
{
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using Diphda.Domain.Abstractions;
    using Diphda.Infrastructure.Repositories;

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

        public async Task Delete(int id)
        {
            await repository.Delete(id);
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await repository.GetAllAsync();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await repository.GetById(id);
        }

        public async Task UpdateAsync(TEntity entity)
        {
            await repository.Update(entity);
        }
    }
}