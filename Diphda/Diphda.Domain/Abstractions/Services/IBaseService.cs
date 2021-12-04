namespace Diphda.Domain.Abstractions
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Diphda.Domain.Account;
    
    public interface IBaseService<TEntity> where TEntity : BaseEntity
    {
        Task<int> AddAsync(TEntity entity);

        Task Delete(int id);

        Task<IEnumerable<TEntity>> GetAllAsync();

        Task<TEntity> GetById(int id);

        Task UpdateAsync(TEntity entity);
    }
}

