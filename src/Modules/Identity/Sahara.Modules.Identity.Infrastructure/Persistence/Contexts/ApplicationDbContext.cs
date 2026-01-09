using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Sahara.Modules.Identity.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Sahara.Modules.Identity.Infrastructure.Persistence.Context
{
    internal sealed class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        internal ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        // ASP.NET Core Identity (EF Core) automatically adds the following DbSets/tables
        // via IdentityDbContext<TUser, TRole, TKey>. These do NOT need to be declared manually:
        //
        // 1. IdentityUser<TKey>          → Users table
        //    Stores user accounts (credentials, email, username, security fields)
        //
        // 2. IdentityRole<TKey>          → Roles table
        //    Stores role definitions (Admin, Vendor, Customer, etc.)
        //
        // 3. IdentityUserRole<TKey>      → UserRoles table
        //    Join table mapping users to roles (many-to-many)
        //
        // 4. IdentityUserClaim<TKey>     → UserClaims table
        //    Claims assigned directly to users
        //
        // 5. IdentityRoleClaim<TKey>     → RoleClaims table
        //    Claims assigned to roles
        //
        // 6. IdentityUserLogin<TKey>     → UserLogins table
        //    External login providers (Google, Microsoft, etc.)
        //
        // 7. IdentityUserToken<TKey>     → UserTokens table
        //    Tokens for MFA, password reset, refresh tokens, etc.
        //
        // 8. (Infrastructure support)
        //    Identity also configures required keys, indexes, relationships,
        //    and concurrency tokens for the above entities automatically.
        //
        // These tables are created and fully configured by the base IdentityDbContext.
        // Only override or extend if custom behavior or additional Identity-owned
        // entities are required.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }
    }
}