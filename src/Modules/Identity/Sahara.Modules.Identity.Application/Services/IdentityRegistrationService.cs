using Microsoft.AspNetCore.Identity;
using Sahara.Modules.Identity.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sahara.Modules.Identity.Application.Services
{
    internal sealed class IdentityRegistrationService
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public IdentityRegistrationService(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }
    }
}
