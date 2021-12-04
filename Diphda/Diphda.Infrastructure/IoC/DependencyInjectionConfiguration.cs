namespace Diphda.Infrastructure
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using Diphda.Domain.Account;
    using Diphda.Domain.Abstractions;
    using Diphda.Infrastructure.Repositories;

    public static class DependencyInjectionConfiguration
    {
        public static void RegisterDependencies(this IServiceCollection service, string databaseConnectionString)
        {
            service.AddDbContext<DatabaseContext>(option => option.UseSqlServer(databaseConnectionString));
            service.AddTransient<IBaseRepository<User>, UserRepository>();
            // service.AddTransient<IBaseService<User>, UserService>();
            // service.AddTransient<IBaseService<BaseEntity>, BaseService<BaseEntity>>();
            // service.AddTransient<IBaseRepository<BaseEntity>, BaseRepository<BaseEntity>>();
            service.AddScoped<DatabaseContext>();
        }
    }
}