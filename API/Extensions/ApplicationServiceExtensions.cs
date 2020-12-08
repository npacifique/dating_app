using API.Data;
using API.Helper;
using API.interfaces;
using API.services;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace API.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            //application services 
            services.AddScoped<ITokenService, TokenService>();

            //add IUserRepository => UserRepository
            services.AddScoped<IUserRepository, UserRepository>();

            //add AutoMapperProfiles
            services.AddAutoMapper(typeof(AutoMapperProfiles).Assembly);
            services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlite(config.GetConnectionString("DefaultConnection"));
            });


            return services;
        }
    }
}