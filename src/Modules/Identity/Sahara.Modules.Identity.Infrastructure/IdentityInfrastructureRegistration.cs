using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Sahara.Modules.Identity.Infrastructure.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sahara.Modules.Identity.Infrastructure
{
    public static class IdentityInfrastructureRegistration
    {
        public static IServiceCollection AddIdentityInfrastructureModule(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            
            return services;
        }
    }
}
