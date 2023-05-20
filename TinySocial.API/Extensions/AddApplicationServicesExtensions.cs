using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TinySocial.DataAccess.Data;
using TinySocial.DataAccess.Interfaces;
using TinySocial.Services.Helpers;
using TinySocial.Services.Interfaces;
using TinySocial.Services.Services;

namespace TinySocial.API.Extensions
{
    public static class AddApplicationServicesExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<ITokenGenerator, TokenGenerator>();
            services.AddAutoMapper(typeof(AutoMapperProfiles).Assembly);
            services.AddDbContext<TinySocialContext>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"));
            });
            return services;
        }
    }
}
