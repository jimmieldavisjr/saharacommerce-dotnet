using Microsoft.AspNetCore.Identity;
using Sahara.Modules.Identity.Application.Contracts.Dtos;
using Sahara.Modules.Identity.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sahara.Modules.Identity.Application.Services
{
    internal class IdentityAccountStateService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public IdentityAccountStateService(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<IdentityAccountStateResponseDto> GetAccountStateByEmailAsync(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);

            if (user == null)
            {
                return new IdentityAccountStateResponseDto
                {
                    Exists = false,
                    UserId = Guid.Empty,
                    EmailConfirmed = false,
                    Roles = new List<string>(),
                    Errors = null
                };
            }

            var roles = (await _userManager.GetRolesAsync(user)).ToList();

            return new IdentityAccountStateResponseDto
            {
                Exists = true,
                UserId = user.Id,
                EmailConfirmed = user.EmailConfirmed,
                Roles = roles,
                Errors = null
            };
        }
    }
}
