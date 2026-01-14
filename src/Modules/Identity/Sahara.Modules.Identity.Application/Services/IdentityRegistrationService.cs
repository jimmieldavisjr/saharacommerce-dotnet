using Microsoft.AspNetCore.Identity;
using Sahara.Modules.Identity.Application.Contracts.Dtos.Registration;
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

        public async Task<IdentityRegistrationResponseDto> RegisterUserAsync(IdentityRegistrationRequestDto request)
        {
            var user = new ApplicationUser
            {
                UserName = request.Email,
                Email = request.Email,
                EmailConfirmed = false
            };

            var resultUser = await _userManager.CreateAsync(user, request.Password);

            var resultRole = await _userManager.AddToRoleAsync(user, request.AccountType.ToString());

            var response = new IdentityRegistrationResponseDto
            {
                Success = resultUser.Succeeded && resultRole.Succeeded,
                UserId = resultUser.Succeeded ? user.Id : Guid.Empty,
                UserErrors = resultUser.Succeeded ? null : resultUser.Errors.Select(e => e.Description).ToList(),
                RoleErrors = resultRole.Succeeded ? null : resultRole.Errors.Select(e => e.Description).ToList()
            };

                return response;
        }
    }
}
