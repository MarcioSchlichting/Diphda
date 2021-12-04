namespace Diphda.Services
{
    using Diphda.Domain.Abstractions;
    using Diphda.Domain.Account;

    public sealed class UserService : BaseService<User>, IUserService
    {
        public UserService(IBaseRepository<User> repository) : base(repository)
        {
        }
    }
}