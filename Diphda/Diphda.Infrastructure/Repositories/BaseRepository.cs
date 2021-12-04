namespace Diphda.Infrastructure.Repositories
{
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Diphda.Domain.Abstractions;

    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly DatabaseContext db;

        public BaseRepository(DatabaseContext db)
        {
            this.db = db;
        }

        public async Task Delete(int id)
        {
            db.Set<TEntity>().Remove(await GetById(id));
            await db.SaveChangesAsync();
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await db.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await db.Set<TEntity>().FindAsync(id);
        }

        public async Task<int> AddAsync(TEntity entity)
        {
            db.Set<TEntity>().Add(entity);
            await db.SaveChangesAsync();

            return entity.Id;
        }

        public async Task Update(TEntity entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            await db.SaveChangesAsync();
        }
    }
}