namespace Diphda.Infrastructure
{
    using AutoMapper;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.IdentityModel.Tokens;
    using Microsoft.AspNetCore.Authentication.JwtBearer;
    using Diphda.Domain.Account;
    using Diphda.Domain.Abstractions;
    using Diphda.Infrastructure.Repositories;
    using Diphda.Services;
    using Diphda.Infrastructure.CrossCutting;
    using Diphda.Application;
    using System.Text;

    public static class ConfigurationExtension
    {
        public static void RegisterDependencies(this IServiceCollection service, string databaseConnectionString)
        {
            service.AddDbContext<DatabaseContext>(option => option.UseSqlServer(databaseConnectionString));
            service.AddTransient<IBaseRepository<User>, UserRepository>();
            service.AddTransient<IBaseService<User>, UserService>();
            service.AddTransient<IBaseService<BaseEntity>, BaseService<BaseEntity>>();
            service.AddTransient<IBaseRepository<BaseEntity>, BaseRepository<BaseEntity>>();
            service.AddScoped<DatabaseContext>();

            var mapperConfig = new MapperConfiguration(config => 
            {
                config.AddProfile(new UserMapping());
            });

            service.AddSingleton(mapperConfig.CreateMapper());
        }

        public static void RegisterAuthentication(this IServiceCollection service)
        {
            service.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(Settings.SECRET)),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });
        }
    }
}