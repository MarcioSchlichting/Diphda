namespace Diphda.Domain.Abstractions
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Diphda.Domain.Account;
    
    public interface IBaseService<TEntity> where TEntity : BaseEntity
    {
        Task<int> AddAsync(TEntity entity);

        Task DeleteAsync(int id);

        Task<IEnumerable<TEntity>> GetAllAsync();

        Task<TEntity> GetByIdAsync(int id);

        Task UpdateAsync(TEntity entity);
    }
}

