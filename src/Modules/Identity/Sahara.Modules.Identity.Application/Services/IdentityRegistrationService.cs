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

        public async Task<IdentityRegistrationResultDto> RegisterUserAsync(IdentityRegistrationRequestDto request)
        {
            var user = new ApplicationUser
            {
                UserName = request.Email,
                Email = request.Email,
                EmailConfirmed = false
            };

            var result = await _userManager.CreateAsync(user, request.Password);

            var response = new IdentityRegistrationResultDto
            {
                Success = result.Succeeded,
                UserId = result.Succeeded ? user.Id : Guid.Empty,
                Errors = result.Succeeded ? null : result.Errors.Select(e => e.Description).ToList()
            };

            return response;
        }
    }
}
