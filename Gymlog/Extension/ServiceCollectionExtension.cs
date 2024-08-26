using Gymlog.Core.Contracts;
using Gymlog.Core.Service;
using Gymlog.Infrastructure.Data.Common;
using Gymlog.Infrastructure.Data.Models;
using Gymlog.Infrastructure.Data.SeedDb;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<ICardService, CardService>();

            return services;
        }

        public static IServiceCollection AddApplicationDbContext(this IServiceCollection sevices, IConfiguration config)
        {
            var connectionString = config.GetConnectionString("DefaultConnection");
            sevices.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString));

            sevices.AddScoped<IRepository, Repository>();

            sevices.AddDatabaseDeveloperPageExceptionFilter();

            return sevices;
        }

        public static IServiceCollection AddApplicationIdentity(this IServiceCollection sevices, IConfiguration config)
        {
            sevices
                .AddDefaultIdentity<ApplicationUser>(options =>
                {
                    options.SignIn.RequireConfirmedAccount = false;
                    options.Password.RequireNonAlphanumeric = false;
                    options.Password.RequireDigit = false;
                    options.Password.RequireLowercase = false;
                    options.Password.RequireUppercase = false;
                })
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>();

            return sevices;
        }


    }
}
