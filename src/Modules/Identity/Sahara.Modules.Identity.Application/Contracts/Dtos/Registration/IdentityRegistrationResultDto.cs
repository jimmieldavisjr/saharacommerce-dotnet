using System;
using System.Collections.Generic;
using System.Text;

namespace Sahara.Modules.Identity.Application.Contracts.Dtos.Registration
{
    internal sealed class IdentityRegistrationResultDto
    {
        public bool Success { get; set; }
        public Guid UserId { get; set; }
        public List<string>? Errors { get; set; } = new List<string>();
    }
}
