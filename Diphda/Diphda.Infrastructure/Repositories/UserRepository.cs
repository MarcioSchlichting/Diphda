namespace Diphda.Infrastructure.Repositories
{
    using Diphda.Domain.Abstractions;
    using Diphda.Domain.Account;
    
    public sealed class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(DatabaseContext db) : base(db)
        {
        }
    }
}