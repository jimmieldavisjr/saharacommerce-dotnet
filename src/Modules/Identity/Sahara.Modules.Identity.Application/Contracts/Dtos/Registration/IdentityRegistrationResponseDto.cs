using System;
using System.Collections.Generic;
using System.Text;

namespace Sahara.Modules.Identity.Application.Contracts.Dtos.Registration
{
    internal sealed class IdentityRegistrationResponseDto
    {
        public bool Success { get; set; }
        public Guid UserId { get; set; }
        public string Role { get; set; }
        public List<string>? UserErrors { get; set; } = new List<string>();
        public List<string>? RoleErrors { get; set; } = new List<string>();
    }
}
