using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sahara.Modules.Identity.Domain.Entities
{
    public sealed class ApplicationUser : IdentityUser<Guid>
    {
        // Lifecycle flags
        public bool IsDeleted { get; set; }
        public bool IsDisabled { get; set; }

        // Operational Auditing
        public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;
        public DateTimeOffset? LastLoginAt { get; set; }
        public DateTimeOffset? DeletedAt { get; set; }
        public DateTimeOffset? DisabledAt { get; set; }
    }
}
