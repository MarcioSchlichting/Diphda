namespace Diphda.Domain.Abstractions
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        Task<int> AddAsync(TEntity entity);

        Task Update(TEntity entity);

        Task Delete(int id);

        Task<IEnumerable<TEntity>> GetAllAsync();

        Task<TEntity> GetById(int id);
    }
}