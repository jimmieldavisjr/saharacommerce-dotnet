using Microsoft.Extensions.DependencyInjection;
using Sahara.Modules.Identity.Application.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sahara.Modules.Identity.Application
{
    public static class IdentityApplicationRegistration
    {
        public static IServiceCollection AddIdentityApplicationModule(this IServiceCollection services)
        {
            return services.AddScoped<IdentityRegistrationService>();
        }
    }
}
